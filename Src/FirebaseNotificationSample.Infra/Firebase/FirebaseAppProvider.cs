using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace FirebaseNotificationSample.Infra.Firebase
{
    public class FirebaseAppProvider
    {
        public FirebaseApp firebaseApp;

        public FirebaseAppProvider(string credentials)
        {
            firebaseApp = FirebaseApp.Create(new AppOptions {
                Credential = GoogleCredential.FromFile(credentials)
            }); 
        }
    }
}