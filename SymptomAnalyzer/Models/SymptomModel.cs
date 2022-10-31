using Microsoft.ML.Data;

namespace SymptomAnalyzer.Models
{
    public class SymptomModel
    {
        [ColumnName(@"itching")]
        public bool Itching { get; set; } = false;

        [ColumnName(@"skin_rash")]
        public bool Skin_rash { get; set; } = false;

        [ColumnName(@"nodal_skin_eruptions")]
        public bool Nodal_skin_eruptions { get; set; } = false;

        [ColumnName(@"continuous_sneezing")]
        public bool Continuous_sneezing { get; set; } = false;

        [ColumnName(@"shivering")]
        public bool Shivering { get; set; } = false;

        [ColumnName(@"chills")]
        public bool Chills { get; set; } = false;

        [ColumnName(@"joint_pain")]
        public bool Joint_pain { get; set; } = false;

        [ColumnName(@"stomach_pain")]
        public bool Stomach_pain { get; set; } = false;

        [ColumnName(@"acidity")]
        public bool Acidity { get; set; } = false;

        [ColumnName(@"ulcers_on_tongue")]
        public bool Ulcers_on_tongue { get; set; } = false;

        [ColumnName(@"muscle_wasting")]
        public bool Muscle_wasting { get; set; } = false;

        [ColumnName(@"vomiting")]
        public bool Vomiting { get; set; } = false;

        [ColumnName(@"burning_micturition")]
        public bool Burning_micturition { get; set; } = false;

        [ColumnName(@"spotting_ urination")]
        public bool Spotting__urination { get; set; } = false;

        [ColumnName(@"fatigue")]
        public bool Fatigue { get; set; } = false;

        [ColumnName(@"weight_gain")]
        public bool Weight_gain { get; set; } = false;

        [ColumnName(@"anxiety")]
        public bool Anxiety { get; set; } = false;

        [ColumnName(@"cold_hands_and_feets")]
        public bool Cold_hands_and_feets { get; set; } = false;

        [ColumnName(@"mood_swings")]
        public bool Mood_swings { get; set; } = false;

        [ColumnName(@"weight_loss")]
        public bool Weight_loss { get; set; } = false;

        [ColumnName(@"restlessness")]
        public bool Restlessness { get; set; } = false;

        [ColumnName(@"lethargy")]
        public bool Lethargy { get; set; } = false;

        [ColumnName(@"patches_in_throat")]
        public bool Patches_in_throat { get; set; } = false;

        [ColumnName(@"irregular_sugar_level")]
        public bool Irregular_sugar_level { get; set; } = false;

        [ColumnName(@"cough")]
        public bool Cough { get; set; } = false;

        [ColumnName(@"high_fever")]
        public bool High_fever { get; set; } = false;

        [ColumnName(@"sunken_eyes")]
        public bool Sunken_eyes { get; set; } = false;

        [ColumnName(@"breathlessness")]
        public bool Breathlessness { get; set; } = false;

        [ColumnName(@"sweating")]
        public bool Sweating { get; set; } = false;

        [ColumnName(@"dehydration")]
        public bool Dehydration { get; set; } = false;

        [ColumnName(@"indigestion")]
        public bool Indigestion { get; set; } = false;

        [ColumnName(@"headache")]
        public bool Headache { get; set; } = false;

        [ColumnName(@"yellowish_skin")]
        public bool Yellowish_skin { get; set; } = false;

        [ColumnName(@"dark_urine")]
        public bool Dark_urine { get; set; } = false;

        [ColumnName(@"nausea")]
        public bool Nausea { get; set; } = false;

        [ColumnName(@"loss_of_appetite")]
        public bool Loss_of_appetite { get; set; } = false;

        [ColumnName(@"pain_behind_the_eyes")]
        public bool Pain_behind_the_eyes { get; set; } = false;

        [ColumnName(@"back_pain")]
        public bool Back_pain { get; set; } = false;

        [ColumnName(@"constipation")]
        public bool Constipation { get; set; } = false;

        [ColumnName(@"abdominal_pain")]
        public bool Abdominal_pain { get; set; } = false;

        [ColumnName(@"diarrhoea")]
        public bool Diarrhoea { get; set; } = false;

        [ColumnName(@"mild_fever")]
        public bool Mild_fever { get; set; } = false;

        [ColumnName(@"yellow_urine")]
        public bool Yellow_urine { get; set; } = false;

        [ColumnName(@"yellowing_of_eyes")]
        public bool Yellowing_of_eyes { get; set; } = false;

        [ColumnName(@"acute_liver_failure")]
        public bool Acute_liver_failure { get; set; } = false;

        [ColumnName(@"fluid_overload")]
        public bool Fluid_overload { get; set; } = false;

        [ColumnName(@"swelling_of_stomach")]
        public bool Swelling_of_stomach { get; set; } = false;

        [ColumnName(@"swelled_lymph_nodes")]
        public bool Swelled_lymph_nodes { get; set; } = false;

        [ColumnName(@"malaise")]
        public bool Malaise { get; set; } = false;

        [ColumnName(@"blurred_and_distorted_vision")]
        public bool Blurred_and_distorted_vision { get; set; } = false;

        [ColumnName(@"phlegm")]
        public bool Phlegm { get; set; } = false;

        [ColumnName(@"throat_irritation")]
        public bool Throat_irritation { get; set; } = false;

        [ColumnName(@"redness_of_eyes")]
        public bool Redness_of_eyes { get; set; } = false;

        [ColumnName(@"sinus_pressure")]
        public bool Sinus_pressure { get; set; } = false;

        [ColumnName(@"runny_nose")]
        public bool Runny_nose { get; set; } = false;

        [ColumnName(@"congestion")]
        public bool Congestion { get; set; } = false;

        [ColumnName(@"chest_pain")]
        public bool Chest_pain { get; set; } = false;

        [ColumnName(@"weakness_in_limbs")]
        public bool Weakness_in_limbs { get; set; } = false;

        [ColumnName(@"fast_heart_rate")]
        public bool Fast_heart_rate { get; set; } = false;

        [ColumnName(@"pain_during_bowel_movements")]
        public bool Pain_during_bowel_movements { get; set; } = false;

        [ColumnName(@"pain_in_anal_region")]
        public bool Pain_in_anal_region { get; set; } = false;

        [ColumnName(@"bloody_stool")]
        public bool Bloody_stool { get; set; } = false;

        [ColumnName(@"irritation_in_anus")]
        public bool Irritation_in_anus { get; set; } = false;

        [ColumnName(@"neck_pain")]
        public bool Neck_pain { get; set; } = false;

        [ColumnName(@"dizziness")]
        public bool Dizziness { get; set; } = false;

        [ColumnName(@"cramps")]
        public bool Cramps { get; set; } = false;

        [ColumnName(@"bruising")]
        public bool Bruising { get; set; } = false;

        [ColumnName(@"obesity")]
        public bool Obesity { get; set; } = false;

        [ColumnName(@"swollen_legs")]
        public bool Swollen_legs { get; set; } = false;

        [ColumnName(@"swollen_blood_vessels")]
        public bool Swollen_blood_vessels { get; set; } = false;

        [ColumnName(@"puffy_face_and_eyes")]
        public bool Puffy_face_and_eyes { get; set; } = false;

        [ColumnName(@"enlarged_thyroid")]
        public bool Enlarged_thyroid { get; set; } = false;

        [ColumnName(@"brittle_nails")]
        public bool Brittle_nails { get; set; } = false;

        [ColumnName(@"swollen_extremeties")]
        public bool Swollen_extremeties { get; set; } = false;

        [ColumnName(@"excessive_hunger")]
        public bool Excessive_hunger { get; set; } = false;

        [ColumnName(@"extra_marital_contacts")]
        public bool Extra_marital_contacts { get; set; } = false;

        [ColumnName(@"drying_and_tingling_lips")]
        public bool Drying_and_tingling_lips { get; set; } = false;

        [ColumnName(@"slurred_speech")]
        public bool Slurred_speech { get; set; } = false;

        [ColumnName(@"knee_pain")]
        public bool Knee_pain { get; set; } = false;

        [ColumnName(@"hip_joint_pain")]
        public bool Hip_joint_pain { get; set; } = false;

        [ColumnName(@"muscle_weakness")]
        public bool Muscle_weakness { get; set; } = false;

        [ColumnName(@"stiff_neck")]
        public bool Stiff_neck { get; set; } = false;

        [ColumnName(@"swelling_joints")]
        public bool Swelling_joints { get; set; } = false;

        [ColumnName(@"movement_stiffness")]
        public bool Movement_stiffness { get; set; } = false;

        [ColumnName(@"spinning_movements")]
        public bool Spinning_movements { get; set; } = false;

        [ColumnName(@"loss_of_balance")]
        public bool Loss_of_balance { get; set; } = false;

        [ColumnName(@"unsteadiness")]
        public bool Unsteadiness { get; set; } = false;

        [ColumnName(@"weakness_of_one_body_side")]
        public bool Weakness_of_one_body_side { get; set; } = false;

        [ColumnName(@"loss_of_smell")]
        public bool Loss_of_smell { get; set; } = false;

        [ColumnName(@"bladder_discomfort")]
        public bool Bladder_discomfort { get; set; } = false;

        [ColumnName(@"foul_smell_of urine")]
        public bool Foul_smell_of_urine { get; set; } = false;

        [ColumnName(@"continuous_feel_of_urine")]
        public bool Continuous_feel_of_urine { get; set; } = false;

        [ColumnName(@"passage_of_gases")]
        public bool Passage_of_gases { get; set; } = false;

        [ColumnName(@"internal_itching")]
        public bool Internal_itching { get; set; } = false;

        [ColumnName(@"toxic_look_(typhos)")]
        public bool Toxic_look__typhos_ { get; set; } = false;

        [ColumnName(@"depression")]
        public bool Depression { get; set; } = false;

        [ColumnName(@"irritability")]
        public bool Irritability { get; set; } = false;

        [ColumnName(@"muscle_pain")]
        public bool Muscle_pain { get; set; } = false;

        [ColumnName(@"altered_sensorium")]
        public bool Altered_sensorium { get; set; } = false;

        [ColumnName(@"red_spots_over_body")]
        public bool Red_spots_over_body { get; set; } = false;

        [ColumnName(@"belly_pain")]
        public bool Belly_pain { get; set; } = false;

        [ColumnName(@"abnormal_menstruation")]
        public bool Abnormal_menstruation { get; set; } = false;

        [ColumnName(@"dischromic _patches")]
        public bool Dischromic__patches { get; set; } = false;

        [ColumnName(@"watering_from_eyes")]
        public bool Watering_from_eyes { get; set; } = false;

        [ColumnName(@"increased_appetite")]
        public bool Increased_appetite { get; set; } = false;

        [ColumnName(@"polyuria")]
        public bool Polyuria { get; set; } = false;

        [ColumnName(@"family_history")]
        public bool Family_history { get; set; } = false;

        [ColumnName(@"mucoid_sputum")]
        public bool Mucoid_sputum { get; set; } = false;

        [ColumnName(@"rusty_sputum")]
        public bool Rusty_sputum { get; set; } = false;

        [ColumnName(@"lack_of_concentration")]
        public bool Lack_of_concentration { get; set; } = false;

        [ColumnName(@"visual_disturbances")]
        public bool Visual_disturbances { get; set; } = false;

        [ColumnName(@"receiving_blood_transfusion")]
        public bool Receiving_blood_transfusion { get; set; } = false;

        [ColumnName(@"receiving_unsterile_injections")]
        public bool Receiving_unsterile_injections { get; set; } = false;

        [ColumnName(@"coma")]
        public bool Coma { get; set; } = false;

        [ColumnName(@"stomach_bleeding")]
        public bool Stomach_bleeding { get; set; } = false;

        [ColumnName(@"distention_of_abdomen")]
        public bool Distention_of_abdomen { get; set; } = false;

        [ColumnName(@"history_of_alcohol_consumption")]
        public bool History_of_alcohol_consumption { get; set; } = false;

        [ColumnName(@"fluid_overload2")]
        public bool Fluid_overload2 { get; set; } = false;

        [ColumnName(@"blood_in_sputum")]
        public bool Blood_in_sputum { get; set; } = false;

        [ColumnName(@"prominent_veins_on_calf")]
        public bool Prominent_veins_on_calf { get; set; } = false;

        [ColumnName(@"palpitations")]
        public bool Palpitations { get; set; } = false;

        [ColumnName(@"painful_walking")]
        public bool Painful_walking { get; set; } = false;

        [ColumnName(@"pus_filled_pimples")]
        public bool Pus_filled_pimples { get; set; } = false;

        [ColumnName(@"blackheads")]
        public bool Blackheads { get; set; } = false;

        [ColumnName(@"scurring")]
        public bool Scurring { get; set; } = false;

        [ColumnName(@"skin_peeling")]
        public bool Skin_peeling { get; set; } = false;

        [ColumnName(@"silver_like_dusting")]
        public bool Silver_like_dusting { get; set; } = false;

        [ColumnName(@"small_dents_in_nails")]
        public bool Small_dents_in_nails { get; set; } = false;

        [ColumnName(@"inflammatory_nails")]
        public bool Inflammatory_nails { get; set; } = false;

        [ColumnName(@"blister")]
        public bool Blister { get; set; } = false;

        [ColumnName(@"red_sore_around_nose")]
        public bool Red_sore_around_nose { get; set; } = false;

        [ColumnName(@"yellow_crust_ooze")]
        public bool Yellow_crust_ooze { get; set; } = false;

        [ColumnName(@"prognosis")]
        public string? Prognosis { get; set; } = "";
    }
}
