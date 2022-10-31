
using Google.Cloud.Firestore;

namespace ConsoleApp1
{
    [FirestoreData]
    public class FirebaseUserProfile
    {
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string State { get; set; }

        [FirestoreProperty]
        public string Country { get; set; }

        [FirestoreProperty]
        public bool Capital { get; set; }

        [FirestoreProperty]
        public long Population { get; set; }
    }

    [FirestoreData]
    public class FirebaseUser
    {
        [FirestoreProperty]
        public string blood_type { get; set; }

        [FirestoreProperty]
        public string em_contact_no { get; set; }

        [FirestoreProperty]
        public string father_name { get; set; }

        [FirestoreProperty]
        public string mother_name { get; set; }

        [FirestoreProperty]
        public string sex { get; set; }
    }

}
