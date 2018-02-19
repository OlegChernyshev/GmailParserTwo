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


            messageFind = 0;
            counter = 0;
            fileFind = 0;
            countMessage = 0;
        }

        // "16146f5b41668414"

        static public int messageFind = 0;
        static public int counter = 0;
        static public int fileFind = 0;
        static public int countMessage = 0;

        /// <summary>
        /// Передача данных на форму 
        /// </summary>
        /// <param name="allMessage">Общее количество найденных сообщений</param>
        /// <param name="downloadMessage">Кол-во обработанных сообщений</param>
        /// <param name="remainingMessage">Кол-во оставшихся сообщений</param>
        /// <param name="countDownloadFiles">Кол-во скачаных файлов из обработаных сообщений</param>
        static public void BackCall( /*ref System.Windows.Forms.Label allMessage , ref string downloadMessage , ref string remainingMessage , ref string countDownloadFiles*/)
        {
            //allMessage.Text = countMessage.ToString();
        }

        public byte[] GetFile(string messageId, string path)
        {

            fileFind++;
            byte[] data = null;
            var emailRequest = service.Users.Messages.Get("me", messageId);
            emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
            var parts = emailRequest.Execute().Payload.Parts;
            if (parts != null)
                foreach (var part in parts)
                {
                    if (!String.IsNullOrEmpty(part.Filename))
                    {
                        String attId = part.Body.AttachmentId;
                        MessagePartBody attachPart = service.Users.Messages.Attachments.Get("me", messageId, attId).Execute();
                        String attachData = attachPart.Data.Replace('-', '+');
                        attachData = attachData.Replace('_', '/');

                        data = Convert.FromBase64String(attachData);
                        //string strin = Encoding.ASCII.GetString(data);
                        //stream.Write(data, 0, data.Length);
                        ++fileFind; ++counter;
                        File.WriteAllBytes(Path.Combine(path, part.Filename), data);

                    }
                }
            return data;
        }

        /// <summary>
        /// Ведет поиск сообщений для полной докачки данных
        /// </summary>
        /// <param name="gRule">Хранит в себе данные о искомых тегах и локальный
        /// адреса хранения данных на компьютере</param>
        /// <param name="messages">Список сообщений с ID и Headers</param>
        /// <returns>Возвращает список id сообщений с которыми совподает теги поиска</returns>
        public List<string> Finds(GRule gRule, List<string> ids)
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
                string[] strs = Regex.Split(gRule.tag, "\\s");

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

        public List<string> Finds(List<GRule> gRules, List<string> ids)
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

        public string Find(GRule gRule, string id)
        {

            messageFind = 0;
            List<string> listId = new List<string>();

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
            string[] strs = Regex.Split(gRule.tag, "\\s");

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


            if (find) { return id; ++messageFind; }
            return String.Empty;
        }

        public List<string> GetMessages(string query)
        {
            List<Message> messages = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(email);
            if (query != null)
                request.Q = query; // "label:отчеты-aliter-axi";
            List<string> ids = new List<string>();
            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    messages.AddRange(response.Messages);
                    //countMessage = messages.Capacity;
                    request.PageToken = response.NextPageToken;

                    foreach (Message mes in messages)
                    {
                        if (mes.Id != lastMessageId)
                        {

                            // костыль !!! 
                            if (!ids.Exists(item => item == mes.Id))
                            {
                                ids.Add(mes.Id);
                                ++countMessage;
                            }
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

        public async Task<List<string>> GetMessagesNew(string query)
        {
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(email);
            if (query != null)
                request.Q = query; // "label:отчеты-aliter-axi";
            request.MaxResults = Int32.MaxValue;
            List<string> ids = new List<string>();
            do
            {
                try
                {
                    ListMessagesResponse response = await request.ExecuteAsync();
                    IList<Message> messages = response.Messages;
                    request.PageToken = response.NextPageToken;
                    foreach (Message mes in messages)
                    {
                        if (mes.Id != lastMessageId)
                        {
                            ids.Add(mes.Id);
                            ++countMessage;
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
    }
}
