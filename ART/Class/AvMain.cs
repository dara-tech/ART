using System;

namespace ART.Class
{
    internal class AvMain
    {
        private int clinicID;
        private string artnum;
        private DateTime? datVisit;
        private string typeVisit;
        private string womenstatus;
        private string pregStatus;
        private DateTime? daPreg;
        private string ancservice;
        private double? weight;
        private double? height;
        private double? temp;
        private int? pulse;
        private int? resp;
        private string blood;
        private string stiPreven;
        private string artAdher;
        private string birthspac;
        private string tBinfect;
        private string partner;
        private string condoms;
        private string cmTypeClient;
        private DateTime? cmDaUse;
        private string cmCondom;
        private string coC;
        private string poc;
        private string cmVaccine;
        private string useOther;
        private string oCMcondom;
        private string oCoc;
        private string oPoC;
        private string oCMVaccin;
        private string oCMother;
        private bool? cough;
        private bool? fever;
        private bool? wlost;
        private bool? drenching;
        private bool? urine;
        private bool? genital;
        private string chemnah;
        private bool? hospital;
        private int? numDay;
        private string causeHospital;
        private bool? missARV;
        private string missTime;
        private string who;
        private bool? eligible;
        private string testID;
        private string function;
        private string tb;
        private string typeTB;
        private string tBtreat;
        private DateTime? daTBtreat;
        private bool? testHIV;
        private string resultHIV;
        private string reCD4;
        private string reVL;
        private string reHCV;
        private string crAG;
        private string crAGResult;
        private bool? vLDetectable;
        private string referred;
        private string oReferred;
        private bool? moderate;
        private bool? renal;
        private bool? rash;
        private bool? hepatitis;
        private bool? peripheral;
        private bool? neutropenia;
        private bool? hyperlipidemia;
        private bool? lactic;
        private bool? hypersensitivity;
        private bool? jaundice;
        private string mTother;
        private string arvreg;
        private string resultHC;
        private string tPTout;
        private string tBout;
        private DateTime? daApp;
        private string vid;
        private string foworker;
        private string country;

        public int ClinicID { get => clinicID; set => clinicID = value; }
        public string Artnum { get => artnum; set => artnum = value; }
        public DateTime? DatVisit { get => datVisit; set => datVisit = value; }
        public string TypeVisit { get => typeVisit; set => typeVisit = value; }
        public string Womenstatus { get => womenstatus; set => womenstatus = value; }
        public string PregStatus { get => pregStatus; set => pregStatus = value; }
        public DateTime? DaPreg { get => daPreg; set => daPreg = value; }
        public string ANCservice { get => ancservice; set => ancservice = value; }
        public double? Weight { get => weight; set => weight = value; }
        public double? Height { get => height; set => height = value; }
        public double? Temp { get => temp; set => temp = value; }
        public int? Pulse { get => pulse; set => pulse = value; }
        public int? Resp { get => resp; set => resp = value; }
        public string Blood { get => blood; set => blood = value; }
        public string StiPreven { get => stiPreven; set => stiPreven = value; }
        public string ArtAdher { get => artAdher; set => artAdher = value; }
        public string Birthspac { get => birthspac; set => birthspac = value; }
        public string TBinfect { get => tBinfect; set => tBinfect = value; }
        public string Partner { get => partner; set => partner = value; }
        public string Condoms { get => condoms; set => condoms = value; }
        public string CmTypeClient { get => cmTypeClient; set => cmTypeClient = value; }
        public DateTime? CmDaUse { get => cmDaUse; set => cmDaUse = value; }
        public string CmCondom { get => cmCondom; set => cmCondom = value; }
        public string CoC { get => coC; set => coC = value; }
        public string Poc { get => poc; set => poc = value; }
        public string CmVaccine { get => cmVaccine; set => cmVaccine = value; }
        public string UseOther { get => useOther; set => useOther = value; }
        public string OCMcondom { get => oCMcondom; set => oCMcondom = value; }
        public string OCoc { get => oCoc; set => oCoc = value; }
        public string OPoC { get => oPoC; set => oPoC = value; }
        public string OCMVaccin { get => oCMVaccin; set => oCMVaccin = value; }
        public string OCMother { get => oCMother; set => oCMother = value; }
        public bool? Cough { get => cough; set => cough = value; }
        public bool? Fever { get => fever; set => fever = value; }
        public bool? Wlost { get => wlost; set => wlost = value; }
        public bool? Drenching { get => drenching; set => drenching = value; }
        public bool? Urine { get => urine; set => urine = value; }
        public bool? Genital { get => genital; set => genital = value; }
        public string Chemnah { get => chemnah; set => chemnah = value; }
        public bool? Hospital { get => hospital; set => hospital = value; }
        public int? NumDay { get => numDay; set => numDay = value; }
        public string CauseHospital { get => causeHospital; set => causeHospital = value; }
        public bool? MissARV { get => missARV; set => missARV = value; }
        public string MissTime { get => missTime; set => missTime = value; }
        public string Who { get => who; set => who = value; }
        public bool? Eligible { get => eligible; set => eligible = value; }
        public string TestID { get => testID; set => testID = value; }
        public string Function { get => function; set => function = value; }
        public string Tb { get => tb; set => tb = value; }
        public string TypeTB { get => typeTB; set => typeTB = value; }
        public string TBtreat { get => tBtreat; set => tBtreat = value; }
        public DateTime? DaTBtreat { get => daTBtreat; set => daTBtreat = value; }
        public bool? TestHIV { get => testHIV; set => testHIV = value; }
        public string ResultHIV { get => resultHIV; set => resultHIV = value; }
        public string ReCD4 { get => reCD4; set => reCD4 = value; }
        public string ReVL { get => reVL; set => reVL = value; }
        public string ReHCV { get => reHCV; set => reHCV = value; }
        public string CrAG { get => crAG; set => crAG = value; }
        public string CrAGResult { get => crAGResult; set => crAGResult = value; }
        public bool? VLDetectable { get => vLDetectable; set => vLDetectable = value; }
        public string Referred { get => referred; set => referred = value; }
        public string OReferred { get => oReferred; set => oReferred = value; }
        public bool? Moderate { get => moderate; set => moderate = value; }
        public bool? Renal { get => renal; set => renal = value; }
        public bool? Rash { get => rash; set => rash = value; }
        public bool? Hepatitis { get => hepatitis; set => hepatitis = value; }
        public bool? Peripheral { get => peripheral; set => peripheral = value; }
        public bool? Neutropenia { get => neutropenia; set => neutropenia = value; }
        public bool? Hyperlipidemia { get => hyperlipidemia; set => hyperlipidemia = value; }
        public bool? Lactic { get => lactic; set => lactic = value; }
        public bool? Hypersensitivity { get => hypersensitivity; set => hypersensitivity = value; }
        public bool? Jaundice { get => jaundice; set => jaundice = value; }
        public string MTother { get => mTother; set => mTother = value; }
        public string Arvreg { get => arvreg; set => arvreg = value; }
        public string ResultHC { get => resultHC; set => resultHC = value; }
        public string TPTout { get => tPTout; set => tPTout = value; }
        public string TBout { get => tBout; set => tBout = value; }
        public DateTime? DaApp { get => daApp; set => daApp = value; }
        public string Vid { get => vid; set => vid = value; }
        public string Foworker { get => foworker; set => foworker = value; }
        public string Country { get => country; set => country = value; }
    }
}
