//using Google.Cloud.Firestore;
//using SymptomAnalyzer.Models;

//namespace SymptomAnalyzer.Helper
//{
//    public class FirestoreFunctions
//    {
//        public readonly static FirestoreDb db = FirestoreDb.Create("carex-87914");

//        public static async Task<FirebaseUserModel> VerifyUserAsync()
//        {
//            DocumentReference docRef = db.Collection("UserData").Document("Qxhmru4Jcegwqakdp1SBR0HUckK2");
//            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
//            if (snapshot.Exists)
//            {
//                return snapshot.ConvertTo<FirebaseUserModel>();
//            }
//            else
//            {
//                return new FirebaseUserModel();
//            }
//        }
//    }
//}
