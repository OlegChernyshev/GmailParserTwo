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

namespace GmailParserViewProgram.Model
{
    public class GMessage
    {
        public string messageId;
        public string raw;
        public MessagePartHeader headers;

        private GmailService service;
        private string email;
        private string password;

        public GMessage(GmailService service, DataLoginModel login)
        {
            this.service = service;
            this.email = login.Email;
            this.password = login.Password;
        }

        // "16146f5b41668414"

        public byte[] GetMessageFile (List<string> messageId , string path)
        {
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
                        File.WriteAllBytes(Path.Combine(path, part.Filename), data);
                    }
                }
            }
            return data;
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
            List<string> listId = new List<string>();
            foreach (string id in ids)
            {
                var messageData = service.Users.Messages.Get("me", id);
                messageData.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Metadata;
                IList<MessagePartHeader> headers = messageData.Execute().Payload.Headers;
                foreach (var val in headers)
                    foreach (GRule item in GRule.grules)
                        if (val.Value == item.tag)
                            listId.Add(id);
            }
            return listId;
        }


        public List<string> GetMessages()
        {
            IList<Message> messages = service.Users.Messages.List(email).Execute().Messages;
            List<string> ids = new List<string>();
            foreach (Message item in messages)
            {
                ids.Add(item.Id);
            }
            return ids;
        }


    }
}
