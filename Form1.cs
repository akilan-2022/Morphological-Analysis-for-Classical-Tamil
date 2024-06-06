using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
namespace Morphological_Analyzer
{
    public partial class morph_frm : Form
    {

        XmlDocument xmlDoc = new XmlDocument();
        XmlDocument xmlVerbDoc = new XmlDocument();
        XmlDocument xmlpostposition = new XmlDocument();
        XmlDocument xmlconjection = new XmlDocument();
        XmlDocument xmlDemonstrative = new XmlDocument();
        XmlDocument xmlParticle = new XmlDocument();
        XmlDocument xmlPronoun = new XmlDocument();
        XmlDocument xmlCaseMarker = new XmlDocument();
        XmlDocument xmlClitics = new XmlDocument();


        XmlNodeList rootword;
        XmlNodeList verbrootword;
        XmlNodeList postpositionroot;
        XmlNodeList conjectwordroot;
        XmlNodeList demarootword;
        XmlNodeList particlerootword;
        XmlNodeList Pronounrootword;
        XmlNodeList casemarkerrootword;
        XmlNodeList cliticsrootword;


        public morph_frm()
        {
            InitializeComponent();
        }

        private void morph_frm_Load(object sender, EventArgs e)
        {
            xmlDoc.Load("D:\\Data\\MA_Feb_2016\\Noun.xml");
            rootword = xmlDoc.GetElementsByTagName("rootword");
            xmlVerbDoc.Load("D:\\Data\\MA_Feb_2016\\Verb.xml");
            verbrootword = xmlVerbDoc.GetElementsByTagName("verbrootword");
            xmlpostposition.Load("D:\\Data\\MA_Feb_2016\\postposition.xml");
            postpositionroot = xmlpostposition.GetElementsByTagName("postpositionroot");
            xmlconjection.Load("D:\\Data\\MA_Feb_2016\\conjuction.xml");
            conjectwordroot = xmlconjection.GetElementsByTagName("conjectwordroot");
            xmlDemonstrative.Load("D:\\Data\\MA_Feb_2016\\Demonstrative.xml");
            demarootword = xmlDemonstrative.GetElementsByTagName("demarootword");
            xmlParticle.Load("D:\\Data\\MA_Feb_2016\\particle.xml");
            particlerootword = xmlParticle.GetElementsByTagName("particlerootword");
            xmlPronoun.Load("D:\\Data\\MA_Feb_2016\\pronoun.xml");
            Pronounrootword = xmlPronoun.GetElementsByTagName("Pronounrootword");
            xmlCaseMarker.Load("D:\\Data\\MA_Feb_2016\\CaseMarker.xml");
            casemarkerrootword = xmlCaseMarker.GetElementsByTagName("casemarkerrootword");
            xmlClitics.Load("D:\\Data\\MA_Feb_2016\\\\clitics.xml");
            cliticsrootword = xmlClitics.GetElementsByTagName("cliticsrootword");
        }

        private void morph_btn_Click(object sender, EventArgs e)
        {
            //  Regex.IsMatch(in_txt, @"\d");
            outtxt.Text = WordTrans1.Transtyle(in_txt.Text);
            // morph_txt.Text = "";
            string txtResult = "";
            string parseword;
            string reminderwords;
            string newline;

            //outtxt.Text = outtxt.Text.Replace('\n', ' ');
           // outtxt.Text = outtxt.Text.Insert('\n','\n');
          //  outtxt.Text = outtxt.Text.Insert  
            outtxt.Text = outtxt.Text.Replace('\n', '$');
            int index = outtxt.Text.IndexOf(" ");

            if (index != -1)
            {
                parseword = outtxt.Text.Substring(0, index).Trim();
                reminderwords = outtxt.Text.Substring(index, outtxt.Text.Length - index).Trim();
            }
            else
            {
                parseword = outtxt.Text;
                reminderwords = "";
            }
            while (parseword.Length != 0)
            {
                newline = "";
                if (parseword.IndexOf("$") != -1)
                {

                    int idx = parseword.IndexOf("$");
                    while (idx != -1)
                    {
                        idx = parseword.IndexOf("$", idx + 1);
                        newline = newline +"\n";
                        //newline = newline + " " + "\n" + " ";
                    }

                    // error in the second page
                    parseword = parseword.Replace("$", " ");
                    //parseword = parseword.Replace("$", " ");
                }
                string rootword_eng;
                string suffixword_eng = "";
                // string suffixword_eng2 = "";
                string seperatedword_eng = "";
                string vowels_replace_word;
                string consonant_repace_word;
                // string yvreplace_word;
                // string nnreplaceword;
                bool inDic = false;
                //bool verDic = false;
                string sfxword = "";
                string removeotru = "kctṭp";

                
                string lastotru = parseword.Substring(parseword.Length - 1, 1);
                //  string last1letter = seperatedword_eng.Substring(seperatedword_eng.Length - 1, 1);

                if (removeotru.LastIndexOf(lastotru) != -1)
                {
                    parseword = parseword.Remove(parseword.Length - 1);
                }

                // check for noun
                inDic = SearchWordRootOfDictionary(parseword);

                if (inDic == true)
                {
                    txtResult = parseword + "/NN";
                    goto verbfinish;
                }

                if  (inDic == false)
                {
                    // check for verb
                    inDic = SearchVerbs(parseword);

                    if (inDic == true)
                    {
                        txtResult = parseword + "/VV";
                        goto verbfinish;
                    }
                    else
                    {
                        // check for conjection
                        inDic = SearchConjection(parseword);
                        if (inDic == true)
                        {
                            txtResult = parseword + "/CC";
                            goto verbfinish;
                        }
                        else
                        {
                            // check for demostrative
                            inDic = SearchDemonst(parseword );
                            if (inDic == true)
                            {
                                txtResult = parseword + "/DD";
                                goto verbfinish;
                            }
                            else
                            {

                                // check for particle
                                inDic = SearchParticle(parseword);
                                if (inDic == true)
                                {
                                    txtResult = parseword + "/PA";
                                    goto verbfinish;
                                }

                                else
                                {
                                    // check for PostPosition
                                    inDic = SearchPostposition(parseword);
                                    if (inDic == true)
                                    {
                                        txtResult = parseword + "/POS";
                                        goto verbfinish;
                                    }
                                    else
                                    {
                                        // check for pronoun
                                        inDic = SearchPronoun(parseword);
                                        if (inDic == true)
                                        {
                                            txtResult = parseword + "/PN";
                                            goto verbfinish;
                                        }
                                        else
                                        {
                                            // check for case marker
                                            
                                            inDic = SearchCasemarker(parseword);
                                            if (inDic == true)
                                            {
                                                txtResult = parseword + "/CM";
                                                goto verbfinish;
                                            }
                                            else
                                            {
                                                // check for clitics

                                                inDic = SearchClitics(parseword);

                                                if (inDic == true)
                                                {
                                                    txtResult = parseword + "/CL";
                                                    goto verbfinish;
                                                }
                                            }
                                        }
                                    }
                                }


                            }
                        }

                    }
                }
                
                
             
               
                               
                txtResult = parseword;
                if (inDic == false) //if not in dictionary, check for suffix word
                {
                    //for (int wordidx = 0; wordidx < 3; wordidx++)
                    string prsword = "";
                    seperatedword_eng = parseword;
                    do
                    {
                        parseword = seperatedword_eng;
                        XmlNodeList Suffixword = xmlDoc.GetElementsByTagName("Suffixword");
                        for (int i = 0; i < Suffixword.Item(0).ChildNodes.Count; i++)
                        {
                            suffixword_eng = Suffixword.Item(0).ChildNodes[i].ChildNodes[1].InnerText;
                            int idx = parseword.IndexOf(suffixword_eng);

                            if (parseword.IndexOf(suffixword_eng) != -1)
                            {
                                if (parseword.Length == idx + suffixword_eng.Length)
                                {
                                    seperatedword_eng = parseword.Substring(0, parseword.LastIndexOf(suffixword_eng));
                                    sfxword = suffixword_eng + " " + sfxword.Trim();
                                    break;
                                }
                            }
                        }
                    } while (string.Compare(parseword, seperatedword_eng) != 0);

                    // for in word 

                    inDic = false;
                    txtResult = parseword + " " + sfxword;
                    if (seperatedword_eng.Length > 0)
                    {
                        if ((inDic = SearchWordRootOfDictionary(seperatedword_eng)))
                        {
                            // for assigned the gramatical catagory
                            seperatedword_eng = seperatedword_eng + "/NN";

                            if (sfxword == "kkaḷ")
                            {
                                sfxword = sfxword.Remove(0, 1);
                                sfxword = sfxword + "/PL";
                                                               
                            }
                           else if (sfxword == "kaḷ")
                           {
                               sfxword = sfxword + "/PL";
                           }

                            txtResult = seperatedword_eng + " " + sfxword.Trim();
                        }
                        if (inDic == false)
                        {
                            string vowels = "aeiou";
                           // string yv = "yv"; for checkeing "v" rules
                            string yv = "y";
                            string dounn = "ṇṇllṭṭ";

                            XmlNodeList rules = xmlDoc.GetElementsByTagName("rules");

                            int sindex = sfxword.IndexOf(" ");
                            string sparseword = "";
                            string sreminderwords = "";

                            if (sindex != -1)
                            {
                                sparseword = sfxword.Substring(0, sindex).Trim();
                                sreminderwords = sfxword.Substring(sindex, sfxword.Length - sindex).Trim();
                            }
                            string prs = "";
                            while (sparseword.Length != 0)
                            {

                                for (int i = 0; i < rules.Item(0).ChildNodes.Count; i++)
                                {

                                    if (string.Compare(sparseword, rules.Item(0).ChildNodes[i].Name) == 0)
                                    {
                                        inDic = SearchWordRootOfDictionary(seperatedword_eng);
                                        if (inDic == true)
                                        {
                                            goto finish;
                                        }
                                        vowels_replace_word = rules.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                                        consonant_repace_word = rules.Item(0).ChildNodes[i].ChildNodes[1].InnerText;


                                        if (seperatedword_eng.Length <= 1)
                                        {
                                            string lastletter = seperatedword_eng.Substring(seperatedword_eng.Length - 1, 1);
                                            // string last2letter = seperatedword_eng.Substring(seperatedword_eng.Length - 2, 2);
                                            if ((vowels.LastIndexOf(lastletter) == -1) && (yv.LastIndexOf(lastletter) == -1))
                                                seperatedword_eng += consonant_repace_word;
                                            else if (yv.LastIndexOf(lastletter) == -1)
                                            
                                                seperatedword_eng = seperatedword_eng.Remove(seperatedword_eng.Length - 1);
                                               
                                            else if (yv.LastIndexOf(lastletter) != -1)
                                                seperatedword_eng = seperatedword_eng.TrimEnd(seperatedword_eng[seperatedword_eng.Length - 1]);
                                            else
                                                seperatedword_eng += vowels_replace_word;
                                            
                                        }

                                        else
                                        {

                                            string last2letter = seperatedword_eng.Substring(seperatedword_eng.Length - 2, 2);
                                            string last1letter = seperatedword_eng.Substring(seperatedword_eng.Length - 1, 1);

                                            if (yv.LastIndexOf(last1letter) != -1)
                                            seperatedword_eng = seperatedword_eng.TrimEnd(seperatedword_eng[seperatedword_eng.Length - 1]);
                                                                                   
                                            else if (dounn.LastIndexOf(last2letter) == -1)
                                                seperatedword_eng += consonant_repace_word;
                                            else if (last2letter == "ṭṭ")
                                            {
                                                seperatedword_eng = seperatedword_eng.Remove(seperatedword_eng.Length - 1);
                                                seperatedword_eng += consonant_repace_word;
                                            }

                                            else if (dounn.LastIndexOf(last2letter) != -1)
                                            
                                                seperatedword_eng = seperatedword_eng.Remove(seperatedword_eng.Length - 1);
                                                
                                            
                                            //else if (yv.LastIndexOf(last1letter) != -1)
                                            //    seperatedword_eng = seperatedword_eng.TrimEnd(seperatedword_eng[seperatedword_eng.Length - 1]);
                                            else
                                                seperatedword_eng += vowels_replace_word;
                                                                                       

                                        }

                                        inDic = SearchWordRootOfDictionary(seperatedword_eng);

                                        if (inDic == true)
                                        {
                                        }
                                        else
                                        {
                                            vowels_replace_word = rules.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                                            consonant_repace_word = rules.Item(0).ChildNodes[i].ChildNodes[1].InnerText;
                                        }

                                        

                                    finish:
                                        if (sparseword == "ṅkaḷ" || sparseword == "ṟkaḷ" || sparseword == "ṭkaḷ" || sparseword == "kkaḷ")
                                        {
                                            sparseword = sparseword.Remove(0, 1);
                                            sparseword = sparseword + "/PL";
                                            prs += " " + sparseword;
                                        }
                                        else
                                        {
                                            //prs += " " + sparseword + "/CM";
                                            prs += " " + sparseword + "/CM";
                                        }
                                       // prs += " " + sparseword;
                                            //if (sparseword != "kaḷ")
                                            //{
                                            //    prs = sparseword + "/CM";
                                            //}
                                            //else
                                            //{
                                            //    prs = sparseword + "/PL";
                                            //}


                                        txtResult = seperatedword_eng + "/NN" + " " + prs; //sparseword + "/CM";
                                        break;

                                    }
                                }

                                sindex = sreminderwords.IndexOf(' ');
                                if (sindex != -1)
                                {
                                    sparseword = sreminderwords.Substring(0, sindex).Trim();
                                    sreminderwords = sreminderwords.Substring(sindex, sreminderwords.Length - sindex).Trim();
                                }
                                else
                                {
                                    sparseword = "";
                                    if (sreminderwords.Length > 0)
                                    {
                                        sparseword = sreminderwords;
                                        sreminderwords = "";
                                    }
                                }
                            }


                        }
                    }
                }

                else
                {
                    txtResult = parseword + "/NN";
                }
                // write for verb
            verbfinish:
                morphResult.Text = txtResult;
                morph_txt.Text = morph_txt.Text.Trim() + " " + newline + TamiltoTrans.Transtyle(morphResult.Text);


                index = reminderwords.IndexOf(' ');
                if (index != -1)
                {
                    parseword = reminderwords.Substring(0, index).Trim();
                    reminderwords = reminderwords.Substring(index, reminderwords.Length - index).Trim();
                }
                else
                {
                    parseword = "";
                    if (reminderwords.Length > 0)
                    {
                        parseword = reminderwords;
                        reminderwords = "";
                    }
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            in_txt.Text = "";
            morph_txt.Text = "";
            outtxt.Text = "";
            morphResult.Text = "";
        }


        string filename, strFileText;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Text File";
            openFileDialog1.Filter = "All Text|*.txt";
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    strFileText = "";
                    openFileDialog1.AddExtension = true;
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                    filename = openFileDialog1.FileName;
                    txtFile.Text = "Location: " + filename;

                    StreamReader fileRead = new StreamReader(filename);
                    strFileText = fileRead.ReadToEnd().ToString();
                    fileRead.Close();
                    in_txt.Text = strFileText;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private bool SearchWordRootOfDictionary(string word)
        {
            string rootword_eng;
            for (int i = 0; i < rootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = rootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, word) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool SearchVerbs(string wordverb)
        {
        string rootword_eng;
            for (int i = 0; i < verbrootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = verbrootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, wordverb) == 0)
                {
                    return true;
                }
            }
            return false;
           
            
        }
        //FindPostposition

        private bool SearchPostposition(string posword)
        {
            string rootword_eng;
            for (int i = 0; i < postpositionroot.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = postpositionroot.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, posword) == 0)
                {
                    return true;
                }
            }
            return false;


        }
        //SearchConjection(conjectword)

        private bool SearchConjection(string conjectword)
        {
            string rootword_eng;
            for (int i = 0; i < conjectwordroot.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = conjectwordroot.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, conjectword) == 0)
                {
                    return true;
                }
            }
            return false;


        }

        // search for demostrative root words
        private bool SearchDemonst(string Demonsword)
        {
            string rootword_eng;
            for (int i = 0; i < demarootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = demarootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, Demonsword) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // search for particle root words

        private bool SearchParticle(string Particleword)
        {
            string rootword_eng;
            for (int i = 0; i < particlerootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = particlerootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, Particleword) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // search for pronoun root words
        private bool SearchPronoun(string Pronounword)
        {
            string rootword_eng;
            for (int i = 0; i < Pronounrootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = Pronounrootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, Pronounword) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        // search for case marker root words

        private bool SearchCasemarker(string CaseMaword)
        {
            string rootword_eng;
            for (int i = 0; i < casemarkerrootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = casemarkerrootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, CaseMaword) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // search for clitics
        private bool SearchClitics(string Cliticsword)
        {
            string rootword_eng;
            for (int i = 0; i < cliticsrootword.Item(0).ChildNodes.Count; i++)
            {
                //compare translated word with dictionary
                rootword_eng = cliticsrootword.Item(0).ChildNodes[i].ChildNodes[0].InnerText;
                if (string.Compare(rootword_eng, Cliticsword) == 0)
                {
                    return true;
                }
            }
            return false;
        }













        private void copy_btn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string line in morph_txt.Lines)
                sb.AppendLine(line);

            Clipboard.SetText(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Language.Text == "Tamil")
            {
                btnBrowse.Text = "கோப்பு";
                key_btn.Text = "விசைப்பலகை";
                morph_btn.Text = "உருபனியல் பகுப்பு";
                copy_btn.Text = "நகல்";
                clr_btn.Text = "நீக்க";
                Language.Text = "ஆங்கிலம்";
                help_btn.Text = "உதவி";
                exit_btn.Text = "வெளியேறு";
            }
            else if (Language.Text == "ஆங்கிலம்")
            {
                btnBrowse.Text = "Browse File";
                key_btn.Text = "Key board";
                morph_btn.Text = "Morphlogical Analyzer";
                copy_btn.Text = "Copy";
                clr_btn.Text = "Clear";
                help_btn.Text = "Help";
                Language.Text = "Tamil";
                exit_btn.Text = "Exit";
           }


        }

        private void key_btn_Click(object sender, EventArgs e)
        {

        }

        private void help_btn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }




    }
}