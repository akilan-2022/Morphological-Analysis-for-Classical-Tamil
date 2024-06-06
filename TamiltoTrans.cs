using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morphological_Analyzer
{
    class TamiltoTrans
    {
        public static string Transtyle(string InWord)
        {
                  

            InWord = InWord.Replace("kā", "கா");
            InWord = InWord.Replace("ṅā", "ஙா");
            InWord = InWord.Replace("cā", "சா");
            InWord = InWord.Replace("ñā", "ஞா");
            InWord = InWord.Replace("ṭā", "டா");
            InWord = InWord.Replace("ṇā", "ணா");
            InWord = InWord.Replace("tā", "தா");
            InWord = InWord.Replace("nā", "நா");
            InWord = InWord.Replace("pā", "பா");
            InWord = InWord.Replace("mā", "மா");
            InWord = InWord.Replace("yā", "யா");
            InWord = InWord.Replace("rā", "ரா");
            InWord = InWord.Replace("lā", "லா");
            InWord = InWord.Replace("vā", "வா");
            InWord = InWord.Replace("ḻā", "ழா");
            InWord = InWord.Replace("ḷā", "ளா");
            InWord = InWord.Replace("ṟā", "றா");
            InWord = InWord.Replace("ṉā", "னா");
            InWord = InWord.Replace("jā", "ஜா");
            InWord = InWord.Replace("ṣā", "ஷா");
            InWord = InWord.Replace("sā", "ஸா");
            InWord = InWord.Replace("hā", "ஹா");

            InWord = InWord.Replace("ki", "கி");
            InWord = InWord.Replace("ṅi", "ஙி");
            InWord = InWord.Replace("ci", "சி");
            InWord = InWord.Replace("ñi", "ஞி");
            InWord = InWord.Replace("ṭi", "டி");
            InWord = InWord.Replace("ṇi", "ணி");
            InWord = InWord.Replace("ti", "தி");
            InWord = InWord.Replace("ni", "நி");
            InWord = InWord.Replace("pi", "பி");
            InWord = InWord.Replace("mi", "மி");
            InWord = InWord.Replace("yi", "யி");
            InWord = InWord.Replace("ri", "ரி");
            InWord = InWord.Replace("li", "லி");
            InWord = InWord.Replace("vi", "வி");
            InWord = InWord.Replace("ḻi", "ழி");
            InWord = InWord.Replace("ḷi", "ளி");
            InWord = InWord.Replace("ṟi", "றி");
            InWord = InWord.Replace("ṉi", "னி");
            InWord = InWord.Replace("ji", "ஜி");
            InWord = InWord.Replace("ṣi", "ஷி");
            InWord = InWord.Replace("si", "ஸி");
            InWord = InWord.Replace("hi", "ஹி");

            InWord = InWord.Replace("kī", "கீ");
            InWord = InWord.Replace("ṅī", "ஙீ");
            InWord = InWord.Replace("cī", "சீ");
            InWord = InWord.Replace("ñī", "ஞீ");
            InWord = InWord.Replace("ṭī", "டீ");
            InWord = InWord.Replace("ṇī", "ணீ");
            InWord = InWord.Replace("tī", "தீ");
            InWord = InWord.Replace("nī", "நீ");
            InWord = InWord.Replace("pī", "பீ");
            InWord = InWord.Replace("mī", "மீ");
            InWord = InWord.Replace("yī", "யீ");
            InWord = InWord.Replace("rī", "ரீ");
            InWord = InWord.Replace("lī", "லீ");
            InWord = InWord.Replace("vī", "வீ");
            InWord = InWord.Replace("ḻī", "ழீ");
            InWord = InWord.Replace("ḷī", "ளீ");
            InWord = InWord.Replace("ṟī", "றீ");
            InWord = InWord.Replace("ṉī", "னீ");
            InWord = InWord.Replace("jī", "ஜீ");
            InWord = InWord.Replace("ṣī", "ஷீ");
            InWord = InWord.Replace("sī", "ஸீ");
            InWord = InWord.Replace("hī", "ஹீ");

            InWord = InWord.Replace("ku", "கு");
            InWord = InWord.Replace("ṅu", "ஙு");
            InWord = InWord.Replace("cu", "சு");
            InWord = InWord.Replace("ñu", "ஞு");
            InWord = InWord.Replace("ṭu", "டு");
            InWord = InWord.Replace("ṇu", "ணு");
            InWord = InWord.Replace("tu", "து");
            InWord = InWord.Replace("nu", "நு");
            InWord = InWord.Replace("pu", "பு");
            InWord = InWord.Replace("mu", "மு");
            InWord = InWord.Replace("yu", "யு");
            InWord = InWord.Replace("ru", "ரு");
            InWord = InWord.Replace("lu", "லு");
            InWord = InWord.Replace("vu", "வு");
            InWord = InWord.Replace("ḻu", "ழு");
            InWord = InWord.Replace("ḷu", "ளு");
            InWord = InWord.Replace("ṟu", "று");
            InWord = InWord.Replace("ṉu", "னு");
            InWord = InWord.Replace("ju", "ஜு");
            InWord = InWord.Replace("ṣu", "ஷு");
            InWord = InWord.Replace("su", "ஸு");
            InWord = InWord.Replace("hu", "ஹு");


            InWord = InWord.Replace("kū", "கூ");
            InWord = InWord.Replace("ṅū", "ஙூ");
            InWord = InWord.Replace("cū", "சூ");
            InWord = InWord.Replace("ñū", "ஞூ");
            InWord = InWord.Replace("ṭū", "டூ");
            InWord = InWord.Replace("ṇū", "ணூ");
            InWord = InWord.Replace("tū", "தூ");
            InWord = InWord.Replace("nū", "நூ");
            InWord = InWord.Replace("pū", "பூ");
            InWord = InWord.Replace("mū", "மூ");
            InWord = InWord.Replace("yū", "யூ");
            InWord = InWord.Replace("rū", "ரூ");
            InWord = InWord.Replace("lū", "லூ");
            InWord = InWord.Replace("vū", "வூ");
            InWord = InWord.Replace("ḻū", "ழூ");
            InWord = InWord.Replace("ḷū", "ளூ");
            InWord = InWord.Replace("ṟū", "றூ");
            InWord = InWord.Replace("ṉū", "னூ");
            InWord = InWord.Replace("jū", "ஜூ");
            InWord = InWord.Replace("ṣū", "ஷூ");
            InWord = InWord.Replace("sū", "ஸூ");
            InWord = InWord.Replace("hū", "ஹூ");

            InWord = InWord.Replace("ke", "கெ");
            InWord = InWord.Replace("ṅe", "ஙெ");
            InWord = InWord.Replace("ce", "செ");
            InWord = InWord.Replace("ñe", "ஞெ");
            InWord = InWord.Replace("ṭe", "டெ");
            InWord = InWord.Replace("ṇe", "ணெ");
            InWord = InWord.Replace("te", "தெ");
            InWord = InWord.Replace("ne", "நெ");
            InWord = InWord.Replace("pe", "பெ");
            InWord = InWord.Replace("me", "மெ");
            InWord = InWord.Replace("ye", "யெ");
            InWord = InWord.Replace("re", "ரெ");
            InWord = InWord.Replace("le", "லெ");
            InWord = InWord.Replace("ve", "வெ");
            InWord = InWord.Replace("ḻe", "ழெ");
            InWord = InWord.Replace("ḷe", "ளெ");
            InWord = InWord.Replace("ṟe", "றெ");
            InWord = InWord.Replace("ṉe", "னெ");
            InWord = InWord.Replace("je", "ஜெ");
            InWord = InWord.Replace("ṣe", "ஷெ");
            InWord = InWord.Replace("se", "ஸெ");
            InWord = InWord.Replace("he", "ஹெ");

            InWord = InWord.Replace("kē", "கே");
            InWord = InWord.Replace("ṅē", "ஙே");
            InWord = InWord.Replace("cē", "சே");
            InWord = InWord.Replace("ñē", "ஞே");
            InWord = InWord.Replace("ṭē", "டே");
            InWord = InWord.Replace("ṇē", "ணே");
            InWord = InWord.Replace("tē", "தே");
            InWord = InWord.Replace("nē", "நே");
            InWord = InWord.Replace("pē", "பே");
            InWord = InWord.Replace("mē", "மே");
            InWord = InWord.Replace("yē", "யே");
            InWord = InWord.Replace("rē", "ரே");
            InWord = InWord.Replace("lē", "லே");
            InWord = InWord.Replace("vē", "வே");
            InWord = InWord.Replace("ḻē", "ழே");
            InWord = InWord.Replace("ḷē", "ளே");
            InWord = InWord.Replace("ṟē", "றே");
            InWord = InWord.Replace("ṉē", "னே");
            InWord = InWord.Replace("jē", "ஜே");
            InWord = InWord.Replace("ṣē", "ஷே");
            InWord = InWord.Replace("sē", "ஸே");
            InWord = InWord.Replace("hē", "ஹே");

            InWord = InWord.Replace("kai", "கை");
            InWord = InWord.Replace("ṅai", "ஙை");
            InWord = InWord.Replace("cai", "சை");
            InWord = InWord.Replace("ñai", "ஞை");
            InWord = InWord.Replace("ṭai", "டை");
            InWord = InWord.Replace("ṇai", "ணை");
            InWord = InWord.Replace("tai", "தை");
            InWord = InWord.Replace("nai", "நை");
            InWord = InWord.Replace("pai", "பை");
            InWord = InWord.Replace("mai", "மை");
            InWord = InWord.Replace("yai", "யை");
            InWord = InWord.Replace("rai", "ரை");
            InWord = InWord.Replace("lai", "லை");
            InWord = InWord.Replace("vai", "வை");
            InWord = InWord.Replace("ḻai", "ழை");
            InWord = InWord.Replace("ḷai", "ளை");
            InWord = InWord.Replace("ṟai", "றை");
            InWord = InWord.Replace("ṉai", "னை");
            InWord = InWord.Replace("jai", "ஜை");
            InWord = InWord.Replace("ṣai", "ஷை");
            InWord = InWord.Replace("sai", "ஸை");
            InWord = InWord.Replace("hai", "ஹை");


            InWord = InWord.Replace("ko", "கொ");
            InWord = InWord.Replace("ṅo", "ஙொ");
            InWord = InWord.Replace("co", "சொ");
            InWord = InWord.Replace("ño", "ஞொ");
            InWord = InWord.Replace("ṭo", "டொ");
            InWord = InWord.Replace("ṇo", "ணொ");
            InWord = InWord.Replace("to", "தொ");
            InWord = InWord.Replace("no", "நொ");
            InWord = InWord.Replace("po", "பொ");
            InWord = InWord.Replace("mo", "மொ");
            InWord = InWord.Replace("yo", "யொ");
            InWord = InWord.Replace("ro", "ரொ");
            InWord = InWord.Replace("lo", "லொ");
            InWord = InWord.Replace("vo", "வொ");
            InWord = InWord.Replace("ḻo", "ழொ");
            InWord = InWord.Replace("ḷo", "ளொ");
            InWord = InWord.Replace("ṟo", "றொ");
            InWord = InWord.Replace("ṉo", "னொ");
            InWord = InWord.Replace("jo", "ஜொ");
            InWord = InWord.Replace("ṣo", "ஷொ");
            InWord = InWord.Replace("so", "ஸொ");
            InWord = InWord.Replace("ho", "ஹொ");



            InWord = InWord.Replace("kō", "கோ");
            InWord = InWord.Replace("ṅō", "ஙோ");
            InWord = InWord.Replace("cō", "சோ");
            InWord = InWord.Replace("ñō", "ஞோ");
            InWord = InWord.Replace("ṭō", "டோ");
            InWord = InWord.Replace("ṇō", "ணோ");
            InWord = InWord.Replace("tō", "தோ");
            InWord = InWord.Replace("nō", "நோ");
            InWord = InWord.Replace("pō", "போ");
            InWord = InWord.Replace("mō", "மோ");
            InWord = InWord.Replace("yō", "யோ");
            InWord = InWord.Replace("rō", "ரோ");
            InWord = InWord.Replace("lō", "லோ");
            InWord = InWord.Replace("vō", "வோ");
            InWord = InWord.Replace("ḻō", "ழோ");
            InWord = InWord.Replace("ḷō", "ளோ");
            InWord = InWord.Replace("ṟō", "றோ");
            InWord = InWord.Replace("ṉō", "னோ");
            InWord = InWord.Replace("jō", "ஜோ");
            InWord = InWord.Replace("ṣō", "ஷோ");
            InWord = InWord.Replace("sō", "ஸோ");
            InWord = InWord.Replace("hō", "ஹோ");




            InWord = InWord.Replace("kau", "கௌ");
            InWord = InWord.Replace("ṅau", "ஙௌ");
            InWord = InWord.Replace("cau", "சௌ");
            InWord = InWord.Replace("ñau", "ஞௌ");
            InWord = InWord.Replace("ṭau", "டௌ");
            InWord = InWord.Replace("ṇau", "ணௌ");
            InWord = InWord.Replace("tau", "தௌ");
            InWord = InWord.Replace("nau", "நௌ");
            InWord = InWord.Replace("pau", "பௌ");
            InWord = InWord.Replace("mau", "மௌ");
            InWord = InWord.Replace("yau", "யௌ");
            InWord = InWord.Replace("rau", "ரௌ");
            InWord = InWord.Replace("lau", "லௌ");
            InWord = InWord.Replace("vau", "வௌ");
            InWord = InWord.Replace("ḻau", "ழௌ");
            InWord = InWord.Replace("ḷau", "ளௌ");
            InWord = InWord.Replace("ṟau", "றௌ");
            InWord = InWord.Replace("ṉau", "னௌ");
            InWord = InWord.Replace("jau", "ஜௌ");
            InWord = InWord.Replace("ṣau", "ஷௌ");
            InWord = InWord.Replace("sau", "ஸௌ");
            InWord = InWord.Replace("hau", "ஹௌ");



            InWord = InWord.Replace("ka", "க");
            InWord = InWord.Replace("ṅa", "ங");
            InWord = InWord.Replace("ca", "ச");
            InWord = InWord.Replace("ña", "ஞ");
            InWord = InWord.Replace("ṭa", "ட");
            InWord = InWord.Replace("ṇa", "ண");
            InWord = InWord.Replace("ta", "த");
            InWord = InWord.Replace("na", "ந");
            InWord = InWord.Replace("pa", "ப");
            InWord = InWord.Replace("ma", "ம");
            InWord = InWord.Replace("ya", "ய");
            InWord = InWord.Replace("ra", "ர");
            InWord = InWord.Replace("la", "ல");
            InWord = InWord.Replace("va", "வ");
            InWord = InWord.Replace("ḻa", "ழ");
            InWord = InWord.Replace("ḷa", "ள");
            InWord = InWord.Replace("ṟa", "ற");
            InWord = InWord.Replace("ṣa", "ஷ");
            InWord = InWord.Replace("ja", "ஜ");
            InWord = InWord.Replace("ṉa", "ன");
            InWord = InWord.Replace("sa", "ஸ");
            InWord = InWord.Replace("ha", "ஹ");

            InWord = InWord.Replace("k", "க்");
            InWord = InWord.Replace("ṅ", "ங்");
            InWord = InWord.Replace("c", "ச்");
            InWord = InWord.Replace("ñ", "ஞ்");
            InWord = InWord.Replace("ṭ", "ட்");
            InWord = InWord.Replace("ṇ", "ண்");
            InWord = InWord.Replace("t", "த்");
            InWord = InWord.Replace("n", "ந்");
            InWord = InWord.Replace("p", "ப்");
            InWord = InWord.Replace("m", "ம்");
            InWord = InWord.Replace("y", "ய்");
            InWord = InWord.Replace("r", "ர்");
            InWord = InWord.Replace("l", "ல்");
            InWord = InWord.Replace("v", "வ்");
            InWord = InWord.Replace("ḻ", "ழ்");
            InWord = InWord.Replace("ḷ", "ள்");
            InWord = InWord.Replace("ṟ", "ற்");
            InWord = InWord.Replace("ṉ", "ன்");
            InWord = InWord.Replace("j", "ஜ்");
            InWord = InWord.Replace("ṣ", "ஷ்");
            InWord = InWord.Replace("s", "ஸ்");
            InWord = InWord.Replace("h", "ஹ்");
           
            InWord = InWord.Replace("ai", "ஐ");
            InWord = InWord.Replace("a", "அ");
            InWord = InWord.Replace("ā", "ஆ");
            InWord = InWord.Replace("i", "இ");
            InWord = InWord.Replace("ī", "ஈ");
            InWord = InWord.Replace("u", "உ");
            InWord = InWord.Replace("ū", "ஊ");
            InWord = InWord.Replace("e", "எ");
            InWord = InWord.Replace("ē", "ஏ");
           // InWord = InWord.Replace("ai", "ஐ");
            InWord = InWord.Replace("o", "ஒ");
            InWord = InWord.Replace("ō", "ஓ");
            InWord = InWord.Replace("au", "ஔ");
            InWord = InWord.Replace("ḵ", "ஃ");
            InWord = InWord.Replace("šrī", "ஸ்ரீ");
            

            return InWord;

        }

    }
}
