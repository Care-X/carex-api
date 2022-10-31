using consosleapp;
using Google.Cloud.Firestore;
using SymptomAnalyzer.Models;

namespace SymptomAnalyzer.Helper
{
    public class FirestoreFunctions
    {
        public readonly static FirestoreDb db = FirestoreDb.Create("carex-87914");

        public static async Task<firebaseusermodel> VerifyUserAsync()
        {
            DocumentReference docRef = db.Collection("UserData").Document("3fKTS8Lk44MBGHBpyZa6KeeQTxd2");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<firebaseusermodel>();
            }
            else
            {
                return new firebaseusermodel();
            }
        }
    }
}
