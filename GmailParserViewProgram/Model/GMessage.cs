using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AE.Net.Mail;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;

using System.Text.RegularExpressions;

namespace GmailParserViewProgram.Model
{
    public class GMessage
    {
        //[25240] 		[218]	"160fa0707e77a766"	string
        //[17538]	"15f9506f0de9e628"	string

        static public string lastMessageId = "";


        public string messageId;
        public string raw;
        public MessagePartHeader headers;

        private GmailService service;
        private string email;
        private string password;

        public GMessage(GmailService service /* , DataLoginModel login */ )
        {
            this.service = service;
            this.email = "me";
            //this.password = login.Password;
        }

        // "16146f5b41668414"

        static public int messageFind = 0;
        static public int counter = 0;
        static public int fileFind = 0;
        static public int countMessage = 0;

        public byte[] GetFile (List<string> messageId, string path)
        {
            counter = messageId.Capacity;
            fileFind = 0;
            byte[] data = null;
            foreach (string id in messageId)
            {
                var emailRequest = service.Users.Messages.Get("me", id);
                emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
                var parts = emailRequest.Execute().Payload.Parts;
                foreach (var part in parts)
                {
                    if (!String.IsNullOrEmpty(part.Filename))
                    {
                        String attId = part.Body.AttachmentId;
                        MessagePartBody attachPart = service.Users.Messages.Attachments.Get("me", id, attId).Execute();

                        // Converting from RFC 4648 base64 to base64url encoding
                        // see http://en.wikipedia.org/wiki/Base64#Implementations_and_history
                        String attachData = attachPart.Data.Replace('-', '+');
                        attachData = attachData.Replace('_', '/');

                        data = Convert.FromBase64String(attachData);
                        //string strin = Encoding.ASCII.GetString(data);
                        //stream.Write(data, 0, data.Length);
                        ++fileFind; counter--;
                        File.WriteAllBytes(Path.Combine(path, part.Filename), data);
                    }
                }
            }
            return data;
        }

        public Task<byte[]> GetFileAsync (List<string> messageId , string path)
        {
            return Task.Run(() => {

                return GetFile(messageId, path);
            });
        }

        public string GetMessageRaw( List<string> messageId )
        {
            foreach (string id in messageId)
            {


                var emailRequest = service.Users.Messages.Get("me", id);
                emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
                Message m = emailRequest.Execute();
                string str1 = m.Payload.Body.Data;
                /*
                emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Raw;
                string myraw = emailRequest.Execute().Raw;
                byte[] bytes = Encoding.ASCII.GetBytes(myraw);
                string str1 = Convert.ToBase64String(bytes);
                */



                //byte[] bytes = Encoding.ASCII.GetBytes(myraw);
                //string str1 = Convert.ToBase64String(bytes);
                //byte[] base64 = Convert.FromBase64String(myraw);
                //string str2 = Convert.ToBase64String(bytes);

                
                var parts = emailRequest.Execute().Payload.Parts;
                foreach (var part in parts)
                {
                    if (!String.IsNullOrEmpty(part.Filename))
                    {
                        String attId = part.Body.AttachmentId;
                        MessagePartBody attachPart = service.Users.Messages.Attachments.Get("me", id, attId).Execute();

                        // Converting from RFC 4648 base64 to base64url encoding
                        // see http://en.wikipedia.org/wiki/Base64#Implementations_and_history
                        String attachData = attachPart.Data.Replace('-', '+');
                        attachData = attachData.Replace('_', '/');

                        byte[] data = Convert.FromBase64String(attachData);
                        string strin = Encoding.ASCII.GetString(data);

                       // File.WriteAllBytes(Path.Combine(outputDir, part.Filename), data);
                    }
                    /*
                    byte[] bytes1 = Encoding.Default.GetBytes(part.Body.Data);
                    string myString = Encoding.ASCII.GetString(bytes);
                    string stringbase64 = Convert.ToBase64String(bytes);
                    */
                }

                string str = emailRequest.Execute().Payload.Body.Data;
                
            }
            return "hello";
        }

        /// <summary>
        /// Ведет поиск сообщений для полной докачки данных
        /// </summary>
        /// <param name="gRule">Хранит в себе данные о искомых тегах и локальный
        /// адреса хранения данных на компьютере</param>
        /// <param name="messages">Список сообщений с ID и Headers</param>
        /// <returns>Возвращает список id сообщений с которыми совподает теги поиска</returns>
        public List<string> Find(GRule gRule, List<string> ids)
        {
            counter = 0;
            messageFind = 0;
            List<string> listId = new List<string>();
            foreach (string id in ids)
            {
                ++counter;
                var messageData = service.Users.Messages.Get("me", id);
                messageData.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Metadata;
                IList<MessagePartHeader> headers = messageData.Execute().Payload.Headers;

                string subject = String.Empty;

                foreach (var item in headers)
                {
                    if (item.Name == "Subject")
                    {
                        subject = item.Value;
                        break;
                    }
                }

                bool find = true;
                string[] strs = Regex.Split(gRule.tag , "\\s");

                foreach (string item in strs)
                    if (!Regex.IsMatch(subject, item))
                    {
                        find = false;
                        break;
                    }
                    else
                    {
                        find = true;
                    }


                if (find) { listId.Add(id); ++messageFind; }
            }
            return listId;
        }

        public List<string> Find(List<GRule> gRules, List<string> ids)
        {
            List<string> listId = new List<string>();
            foreach (string id in ids)
            {
                var messageData = service.Users.Messages.Get("me", id);
                messageData.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Metadata;
                IList<MessagePartHeader> headers = messageData.Execute().Payload.Headers;

                foreach (var val in headers)
                    foreach (GRule item in gRules)
                        if (val.Value == item.tag)
                            listId.Add(id);
                         


            }
            return listId;
        }

        public Task<List<string>> FindAsync(GRule gRule, List<string> ids)
        {
            return Task.Run(() =>
            {
                return Find(gRule, ids);
            });
        }

        public List<string> GetMessages()
        {
            List<Message> messages = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(email);
            //var s = service.Users.Threads.List(email);
            List<string> ids = new List<string>();

            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    messages.AddRange(response.Messages);
                    //countMessage = messages.Capacity;
                    request.PageToken = response.NextPageToken;

                    foreach (Message item in messages)
                    {
                        if (item.Id != lastMessageId)
                        {
                            ids.Add(item.Id);
                            countMessage = ids.Capacity;
                        }
                        else return ids;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            
            return ids;
        }

        public Task<List<string>> GetMessageAsync ()
        {
            return Task.Run(() =>
            {
                return GetMessages();
            });
        }


    }
}
