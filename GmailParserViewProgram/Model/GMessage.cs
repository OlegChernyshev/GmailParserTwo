using System;
using System.Collections.Generic;
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

        public string GetMessageRaw( List<string> messageId )
        {
            foreach (string id in messageId)
            {


                var emailRequest = service.Users.Messages.Get("me", id);
                emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
                Message m = emailRequest.Execute();
                /*
                emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Raw;
                byte[] bytes = Encoding.ASCII.GetBytes(emailRequest.Execute().Raw);
                string str = Convert.ToBase64String(bytes);
                */
                var parts = emailRequest.Execute().Payload.Parts;
                foreach (var part in parts)
                {
                    byte[] bytes = Encoding.Default.GetBytes(part.Body.Data);
                    string myString = Encoding.UTF8.GetString(bytes);
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
