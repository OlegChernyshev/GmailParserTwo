using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AE.Net.Mail;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;

using GmailParserViewProgram.Act;

namespace GmailParser
{
    public class UserData
    {
        static private UserData userData = null;
        static public UserData Init()
        {
            Debug.Write("init create");
            return userData = new UserData();
        }

        static public UserData GetUserData()
        {
            return userData;
        }

        private string email;
        public string Email { get { return email; } set { email = value.ToString(); } }


        private UserCredential credential;
        public UserCredential UserCredential
        {
            get
            {
                return credential;
            }
            private set
            {
                credential = value;
            }
        }

        private GmailService gmailService;
        public GmailService GmailService
        {
            get
            {
                return gmailService;
            }
            private set
            {
                gmailService = value;
            }
        }

        public void CreateGmailService()
        {
            string ApplicationName = "EmailParser.EBFI";

            FileParser.Delete(GoogleWebAuthorizationBroker.Folder);

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "924776002477-2lmjf195p2ajjbshcsubeg2sr9lmordv.apps.googleusercontent.com",
                    ClientSecret = "6o1rF8fLCdzYbzmOojU6UoYn"
                },
                new[] { GmailService.Scope.GmailModify },
                "user",
                CancellationToken.None
            ).Result;

            
            
            string[] scopes = new string[]
            {
                GmailService.Scope.GmailReadonly,
                GmailService.Scope.MailGoogleCom,
                GmailService.Scope.GmailMetadata
            };

            gmailService = new GmailService(new BaseClientService.Initializer
            {
                ApplicationName = "GmailParserViewProgram",
                HttpClientInitializer = credential
            });
        }

        public void func()
        {
            var request = gmailService.Users.Messages.List("me");
     
            // List labels.
            IList<Message> labels = request.Execute().Messages;

            if (labels != null && labels.Count > 0)
            {
                foreach (var labelItem in labels)
                {
                    string str = "null";
                    //str = labelItem.
                    //Console.WriteLine("{0}", labelItem.Name);
                }
            }
            else
            {
                //Console.WriteLine("No labels found.");
            }
            //Console.Read();
        }

        /*
        public async void GoogleAutorization (string email)
        {
            ClientSecrets clientSecrets = new ClientSecrets()
            {
                ClientId
            };

            GoogleWebAuthorizationBroker.AuthorizeAsync()
        }
        */

        public List<Message> ListMessagesMatchungQuerty(GmailService service, String userId, String query)
        {

            List<Message> result = new List<Message>();

            var items = service.Users.Messages.List(userId).Execute().Messages;

            // мое тестовое письмо
            var emailRequest = service.Users.Messages.Get("me", "16146f5b41668414");
            //emailRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Raw;
            Message message = emailRequest.Execute();


            //service.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Raw;

            IList<MessagePartHeader> headers = message.Payload.Headers;

            foreach (var val in headers)
                if (val.Value == "TestTag")
                    if (message.Payload.Body != null)
                    {
                        byte[] data = Convert.FromBase64String(message.Payload.Body.Data);
                        string decodedString = Encoding.UTF8.GetString(data);
                    }
            

            foreach (var mes in items)
            {
                Message m = service.Users.Messages.Get(userId , mes.Id).Execute();
                //IList<MessagePart> mpl = m.Payload.Parts;

                //foreach (var mpbi in m.Payload.Parts)
                { 

                    // декодинг
                    //byte[] data = Convert.FromBase64String(m.Payload.Body.Data);
                    //string decodedString = Encoding.UTF8.GetString(data);
                }
                /*
                // m.Payload is populated now.
                foreach (var part in message.Payload.Parts)
                {
                    byte[] data = Convert.FromBase64String(part.Body.Data);
                    string decodedString = Encoding.UTF8.GetString(data);
                    Console.WriteLine(decodedString);
                }*/
            }
            return result;
        }

        public static Message GetMessage(GmailService service, String userId, String messageId)
        {
            try
            {
                return service.Users.Messages.Get(userId, messageId).Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return null;
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }
    }
}
