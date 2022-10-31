// Save this program as MainReturnValTest.cs.
using ConsoleApp1;
using Google.Cloud.Firestore;

class Program
{
    public readonly static FirestoreDb db = FirestoreDb.Create("carex-87914");
    static async Task Main()
    {
        //        CollectionReference citiesRef = db.Collection("cities");
        //        await citiesRef.Document("SdF").SetAsync(new Dictionary<string, object>(){
        //    { "Name", "San Francisco" },
        //    { "State", "CA" },
        //    { "Country", "USA" },
        //    { "Capital", false },
        //    { "Population", 860000 }
        //});

        DocumentReference docRef = db.Collection("UserData").Document("Qxhmru4Jcegwqakdp1SBR0HUckK2");
        DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
        if (snapshot.Exists)
        {
            Console.WriteLine("Document data for {0} document:", snapshot.Id);
            FirebaseUser city = snapshot.ConvertTo<FirebaseUser>();
            Console.WriteLine("Name: {0}", city.blood_type);
            Console.WriteLine("State: {0}", city.em_contact_no);
            Console.WriteLine("Country: {0}", city.father_name);
            Console.WriteLine("Capital: {0}", city.mother_name);
            Console.WriteLine("Population: {0}", city.sex);
        }
        else
        {
            Console.WriteLine("Document {0} does not exist!", snapshot.Id);
        }

        //DocumentReference docRef = db.Collection("users").Document("alovelace");
        //Dictionary<string, object> user = new Dictionary<string, object>
        //{
        //    { "First", "Ada" },
        //    { "Last", "Lovelace" },
        //    { "Born", 1815 }
        //};
        //await docRef.SetAsync(user);
    }

}