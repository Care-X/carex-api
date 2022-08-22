using Microsoft.ML.Data;

namespace SymptomAnalyzer.Models
{
    public class SymptomModel
    {
        [ColumnName(@"itching")]
        public bool Itching { get; set; }

        [ColumnName(@"skin_rash")]
        public bool Skin_rash { get; set; }

        [ColumnName(@"nodal_skin_eruptions")]
        public bool Nodal_skin_eruptions { get; set; }

        [ColumnName(@"continuous_sneezing")]
        public bool Continuous_sneezing { get; set; }

        [ColumnName(@"shivering")]
        public bool Shivering { get; set; }

        [ColumnName(@"chills")]
        public bool Chills { get; set; }

        [ColumnName(@"joint_pain")]
        public bool Joint_pain { get; set; }

        [ColumnName(@"stomach_pain")]
        public bool Stomach_pain { get; set; }

        [ColumnName(@"acidity")]
        public bool Acidity { get; set; }

        [ColumnName(@"ulcers_on_tongue")]
        public bool Ulcers_on_tongue { get; set; }

        [ColumnName(@"muscle_wasting")]
        public bool Muscle_wasting { get; set; }

        [ColumnName(@"vomiting")]
        public bool Vomiting { get; set; }

        [ColumnName(@"burning_micturition")]
        public bool Burning_micturition { get; set; }

        [ColumnName(@"spotting_ urination")]
        public bool Spotting__urination { get; set; }

        [ColumnName(@"fatigue")]
        public bool Fatigue { get; set; }

        [ColumnName(@"weight_gain")]
        public bool Weight_gain { get; set; }

        [ColumnName(@"anxiety")]
        public bool Anxiety { get; set; }

        [ColumnName(@"cold_hands_and_feets")]
        public bool Cold_hands_and_feets { get; set; }

        [ColumnName(@"mood_swings")]
        public bool Mood_swings { get; set; }

        [ColumnName(@"weight_loss")]
        public bool Weight_loss { get; set; }

        [ColumnName(@"restlessness")]
        public bool Restlessness { get; set; }

        [ColumnName(@"lethargy")]
        public bool Lethargy { get; set; }

        [ColumnName(@"patches_in_throat")]
        public bool Patches_in_throat { get; set; }

        [ColumnName(@"irregular_sugar_level")]
        public bool Irregular_sugar_level { get; set; }

        [ColumnName(@"cough")]
        public bool Cough { get; set; }

        [ColumnName(@"high_fever")]
        public bool High_fever { get; set; }

        [ColumnName(@"sunken_eyes")]
        public bool Sunken_eyes { get; set; }

        [ColumnName(@"breathlessness")]
        public bool Breathlessness { get; set; }

        [ColumnName(@"sweating")]
        public bool Sweating { get; set; }

        [ColumnName(@"dehydration")]
        public bool Dehydration { get; set; }

        [ColumnName(@"indigestion")]
        public bool Indigestion { get; set; }

        [ColumnName(@"headache")]
        public bool Headache { get; set; }

        [ColumnName(@"yellowish_skin")]
        public bool Yellowish_skin { get; set; }

        [ColumnName(@"dark_urine")]
        public bool Dark_urine { get; set; }

        [ColumnName(@"nausea")]
        public bool Nausea { get; set; }

        [ColumnName(@"loss_of_appetite")]
        public bool Loss_of_appetite { get; set; }

        [ColumnName(@"pain_behind_the_eyes")]
        public bool Pain_behind_the_eyes { get; set; }

        [ColumnName(@"back_pain")]
        public bool Back_pain { get; set; }

        [ColumnName(@"constipation")]
        public bool Constipation { get; set; }

        [ColumnName(@"abdominal_pain")]
        public bool Abdominal_pain { get; set; }

        [ColumnName(@"diarrhoea")]
        public bool Diarrhoea { get; set; }

        [ColumnName(@"mild_fever")]
        public bool Mild_fever { get; set; }

        [ColumnName(@"yellow_urine")]
        public bool Yellow_urine { get; set; }

        [ColumnName(@"yellowing_of_eyes")]
        public bool Yellowing_of_eyes { get; set; }

        [ColumnName(@"acute_liver_failure")]
        public bool Acute_liver_failure { get; set; }

        [ColumnName(@"fluid_overload")]
        public bool Fluid_overload { get; set; }

        [ColumnName(@"swelling_of_stomach")]
        public bool Swelling_of_stomach { get; set; }

        [ColumnName(@"swelled_lymph_nodes")]
        public bool Swelled_lymph_nodes { get; set; }

        [ColumnName(@"malaise")]
        public bool Malaise { get; set; }

        [ColumnName(@"blurred_and_distorted_vision")]
        public bool Blurred_and_distorted_vision { get; set; }

        [ColumnName(@"phlegm")]
        public bool Phlegm { get; set; }

        [ColumnName(@"throat_irritation")]
        public bool Throat_irritation { get; set; }

        [ColumnName(@"redness_of_eyes")]
        public bool Redness_of_eyes { get; set; }

        [ColumnName(@"sinus_pressure")]
        public bool Sinus_pressure { get; set; }

        [ColumnName(@"runny_nose")]
        public bool Runny_nose { get; set; }

        [ColumnName(@"congestion")]
        public bool Congestion { get; set; }

        [ColumnName(@"chest_pain")]
        public bool Chest_pain { get; set; }

        [ColumnName(@"weakness_in_limbs")]
        public bool Weakness_in_limbs { get; set; }

        [ColumnName(@"fast_heart_rate")]
        public bool Fast_heart_rate { get; set; }

        [ColumnName(@"pain_during_bowel_movements")]
        public bool Pain_during_bowel_movements { get; set; }

        [ColumnName(@"pain_in_anal_region")]
        public bool Pain_in_anal_region { get; set; }

        [ColumnName(@"bloody_stool")]
        public bool Bloody_stool { get; set; }

        [ColumnName(@"irritation_in_anus")]
        public bool Irritation_in_anus { get; set; }

        [ColumnName(@"neck_pain")]
        public bool Neck_pain { get; set; }

        [ColumnName(@"dizziness")]
        public bool Dizziness { get; set; }

        [ColumnName(@"cramps")]
        public bool Cramps { get; set; }

        [ColumnName(@"bruising")]
        public bool Bruising { get; set; }

        [ColumnName(@"obesity")]
        public bool Obesity { get; set; }

        [ColumnName(@"swollen_legs")]
        public bool Swollen_legs { get; set; }

        [ColumnName(@"swollen_blood_vessels")]
        public bool Swollen_blood_vessels { get; set; }

        [ColumnName(@"puffy_face_and_eyes")]
        public bool Puffy_face_and_eyes { get; set; }

        [ColumnName(@"enlarged_thyroid")]
        public bool Enlarged_thyroid { get; set; }

        [ColumnName(@"brittle_nails")]
        public bool Brittle_nails { get; set; }

        [ColumnName(@"swollen_extremeties")]
        public bool Swollen_extremeties { get; set; }

        [ColumnName(@"excessive_hunger")]
        public bool Excessive_hunger { get; set; }

        [ColumnName(@"extra_marital_contacts")]
        public bool Extra_marital_contacts { get; set; }

        [ColumnName(@"drying_and_tingling_lips")]
        public bool Drying_and_tingling_lips { get; set; }

        [ColumnName(@"slurred_speech")]
        public bool Slurred_speech { get; set; }

        [ColumnName(@"knee_pain")]
        public bool Knee_pain { get; set; }

        [ColumnName(@"hip_joint_pain")]
        public bool Hip_joint_pain { get; set; }

        [ColumnName(@"muscle_weakness")]
        public bool Muscle_weakness { get; set; }

        [ColumnName(@"stiff_neck")]
        public bool Stiff_neck { get; set; }

        [ColumnName(@"swelling_joints")]
        public bool Swelling_joints { get; set; }

        [ColumnName(@"movement_stiffness")]
        public bool Movement_stiffness { get; set; }

        [ColumnName(@"spinning_movements")]
        public bool Spinning_movements { get; set; }

        [ColumnName(@"loss_of_balance")]
        public bool Loss_of_balance { get; set; }

        [ColumnName(@"unsteadiness")]
        public bool Unsteadiness { get; set; }

        [ColumnName(@"weakness_of_one_body_side")]
        public bool Weakness_of_one_body_side { get; set; }

        [ColumnName(@"loss_of_smell")]
        public bool Loss_of_smell { get; set; }

        [ColumnName(@"bladder_discomfort")]
        public bool Bladder_discomfort { get; set; }

        [ColumnName(@"foul_smell_of urine")]
        public bool Foul_smell_of_urine { get; set; }

        [ColumnName(@"continuous_feel_of_urine")]
        public bool Continuous_feel_of_urine { get; set; }

        [ColumnName(@"passage_of_gases")]
        public bool Passage_of_gases { get; set; }

        [ColumnName(@"internal_itching")]
        public bool Internal_itching { get; set; }

        [ColumnName(@"toxic_look_(typhos)")]
        public bool Toxic_look__typhos_ { get; set; }

        [ColumnName(@"depression")]
        public bool Depression { get; set; }

        [ColumnName(@"irritability")]
        public bool Irritability { get; set; }

        [ColumnName(@"muscle_pain")]
        public bool Muscle_pain { get; set; }

        [ColumnName(@"altered_sensorium")]
        public bool Altered_sensorium { get; set; }

        [ColumnName(@"red_spots_over_body")]
        public bool Red_spots_over_body { get; set; }

        [ColumnName(@"belly_pain")]
        public bool Belly_pain { get; set; }

        [ColumnName(@"abnormal_menstruation")]
        public bool Abnormal_menstruation { get; set; }

        [ColumnName(@"dischromic _patches")]
        public bool Dischromic__patches { get; set; }

        [ColumnName(@"watering_from_eyes")]
        public bool Watering_from_eyes { get; set; }

        [ColumnName(@"increased_appetite")]
        public bool Increased_appetite { get; set; }

        [ColumnName(@"polyuria")]
        public bool Polyuria { get; set; }

        [ColumnName(@"family_history")]
        public bool Family_history { get; set; }

        [ColumnName(@"mucoid_sputum")]
        public bool Mucoid_sputum { get; set; }

        [ColumnName(@"rusty_sputum")]
        public bool Rusty_sputum { get; set; }

        [ColumnName(@"lack_of_concentration")]
        public bool Lack_of_concentration { get; set; }

        [ColumnName(@"visual_disturbances")]
        public bool Visual_disturbances { get; set; }

        [ColumnName(@"receiving_blood_transfusion")]
        public bool Receiving_blood_transfusion { get; set; }

        [ColumnName(@"receiving_unsterile_injections")]
        public bool Receiving_unsterile_injections { get; set; }

        [ColumnName(@"coma")]
        public bool Coma { get; set; }

        [ColumnName(@"stomach_bleeding")]
        public bool Stomach_bleeding { get; set; }

        [ColumnName(@"distention_of_abdomen")]
        public bool Distention_of_abdomen { get; set; }

        [ColumnName(@"history_of_alcohol_consumption")]
        public bool History_of_alcohol_consumption { get; set; }

        [ColumnName(@"fluid_overload2")]
        public bool Fluid_overload2 { get; set; }

        [ColumnName(@"blood_in_sputum")]
        public bool Blood_in_sputum { get; set; }

        [ColumnName(@"prominent_veins_on_calf")]
        public bool Prominent_veins_on_calf { get; set; }

        [ColumnName(@"palpitations")]
        public bool Palpitations { get; set; }

        [ColumnName(@"painful_walking")]
        public bool Painful_walking { get; set; }

        [ColumnName(@"pus_filled_pimples")]
        public bool Pus_filled_pimples { get; set; }

        [ColumnName(@"blackheads")]
        public bool Blackheads { get; set; }

        [ColumnName(@"scurring")]
        public bool Scurring { get; set; }

        [ColumnName(@"skin_peeling")]
        public bool Skin_peeling { get; set; }

        [ColumnName(@"silver_like_dusting")]
        public bool Silver_like_dusting { get; set; }

        [ColumnName(@"small_dents_in_nails")]
        public bool Small_dents_in_nails { get; set; }

        [ColumnName(@"inflammatory_nails")]
        public bool Inflammatory_nails { get; set; }

        [ColumnName(@"blister")]
        public bool Blister { get; set; }

        [ColumnName(@"red_sore_around_nose")]
        public bool Red_sore_around_nose { get; set; }

        [ColumnName(@"yellow_crust_ooze")]
        public bool Yellow_crust_ooze { get; set; }

        [ColumnName(@"prognosis")]
        public string Prognosis { get; set; }

        [ColumnName(@"column134")]
        public bool Column134 { get; set; }
    }
}
