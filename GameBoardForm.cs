using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

/// <summary>
/// Name:       James Horton
/// Date:       12/13/2018
/// Assignment: Final Hands On
/// File:       FinalHandsOnJeapordy Jim Horton
/// </summary>

namespace FinalHandsOnJeapordy_Jim_Horton
{
    public partial class GameBoardForm : Form
    {
        #region --- Private Properties ---
        private string player1;// = string.Empty;
        private string player2;// = string.Empty;
        private string player3;// = string.Empty;
        private int players;

        private Player conOne;
        private Player conTwo;
        private Player conThree;
        //private Player current;
        private Jeopardy loadedObject;
        private string whichBox;

        #endregion -- Privates --

        #region --- Public Fields ---
        public string Player1 { get => player1; set => player1 = value; }
        public string Player2 { get => player2; set => player2 = value; }
        public string Player3 { get => player3; set => player3 = value; }
        public int Players { get => players; set => players = value; }
        #endregion -- publics --
                
        double score = 0;
        double points;
        int currentPlayer;
        int btnClick = 0;
        int playersGuessed = 0;
        
        public GameBoardForm()
        {
            var projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            var filePath = Path.Combine(projectPath, "Resources", "Jeopardy.xml");

            InitializeComponent();
            XmlSerializer serializer = new XmlSerializer(typeof(Jeopardy));
            FileStream loadStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            loadedObject = (Jeopardy)serializer.Deserialize(loadStream);
            loadStream.Close();
        }

        /// <summary>
        /// loads game board and text to all btns
        ///  creates the  loadObject of xml
        ///  and sets player objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GameBoardForm_Load(object sender, EventArgs e)
        {
            conOne = new Player(player1, score);
            conTwo = new Player(player2, score);
            conThree = new Player(player3, score);
            // do a switch case for num players to create object
            // and display appropriate board
            switch (players)
            {
                case 1:
                    {
                        //Player conOne = new Player(player1, score);
                        label1.Text = player1;    // tester for passing name
                        label1.Visible = true;
                        txtBxPlyr1Score.Visible = true;
                        txtBxPlyr1Score.Text = score.ToString();
                        // need to create player object                                      
                        break;
                    } // end of case 1
                case 2:
                    {
                        //Player conOne = new Player(player1, score);
                        //Player conTwo = new Player(player2, score);
                        label1.Text = player1;    // tester for passing name
                        label1.Visible = true;
                        txtBxPlyr1Score.Visible = true;
                        txtBxPlyr1Score.Text = score.ToString();
                        label2.Text = player2;    // tester for passing name
                        label2.Visible = true;
                        txtBxPlyr2Score.Visible = true;
                        txtBxPlyr2Score.Text = score.ToString();

                        // need to create 2 player objects                                   
                        break;
                    } // end of case 2
                case 3:
                    {
                        //Player conOne = new Player(player1, score);
                        //Player conTwo = new Player(player2, score);
                        //Player conThree = new Player(player3, score);
                        label1.Text = player1;    // tester for passing name
                        label1.Visible = true;
                        txtBxPlyr1Score.Visible = true;
                        txtBxPlyr1Score.Text = score.ToString();
                        label2.Text = player2;    // tester for passing name
                        label2.Visible = true;
                        txtBxPlyr2Score.Visible = true;
                        txtBxPlyr2Score.Text = score.ToString();
                        label3.Text = player3;    // tester for passing name
                        label3.Visible = true;
                        txtBxPlyr3Score.Visible = true;
                        txtBxPlyr3Score.Text = score.ToString();

                        // need to create 3 player objects                                  
                        break;
                    } // end of case 3

            } // end of switch        

            #region --- Load Point values on Buttons ---
            for (int lcv = 0; lcv < 5; lcv ++)
            {
                int x = lcv + 1;
                string buttonName = "btnCat" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].name.ToString();
            } // end of for loop to load categories to btns

            for (int lcv = 0; lcv < 5; lcv++)
            {
                //int btn = lcv + 5;
                int x = lcv + 1;
                string buttonName = "button" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].first.points.ToString();
            } // end of for loop to load btns

            for (int lcv = 0; lcv < 5; lcv++)
            {
                //int btn = lcv + 5;
                int x = lcv + 6;
                string buttonName = "button" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].second.points.ToString();
            } // end of for loop to load btns

            for (int lcv = 0; lcv < 5; lcv++)
            {
                //int btn = lcv + 5;
                int x = lcv + 11;
                string buttonName = "button" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].third.points.ToString();
            } // end of for loop to load btns

            for (int lcv = 0; lcv < 5; lcv++)
            {
                //int btn = lcv + 5;
                int x = lcv +16;
                string buttonName = "button" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].fourth.points.ToString();
            } // end of for loop to load btns

            for (int lcv = 0; lcv < 5; lcv++)
            {
                //int btn = lcv + 5;
                int x = lcv + 21;
                string buttonName = "button" + x;
                this.Controls[buttonName].Text = loadedObject.category[lcv].fifth.points.ToString();
            } // end of for loop to load btns
            #endregion -- load btn text --

        } // end of form load

            // *****************************
            // this region of code was auto generated to load the xml into 
            // its own objects
        #region --- classes for jeapordy objects ---
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Jeopardy
        {

            private JeopardyCategory[] categoryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("category")]
            public JeopardyCategory[] category
            {
                get
                {
                    return this.categoryField;
                }
                set
                {
                    this.categoryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategory
        {

            private JeopardyCategoryFirst firstField;

            private JeopardyCategorySecond secondField;

            private JeopardyCategoryThird thirdField;

            private JeopardyCategoryFourth fourthField;

            private JeopardyCategoryFifth fifthField;

            private string nameField;

            /// <remarks/>
            public JeopardyCategoryFirst first
            {
                get
                {
                    return this.firstField;
                }
                set
                {
                    this.firstField = value;
                }
            }

            /// <remarks/>
            public JeopardyCategorySecond second
            {
                get
                {
                    return this.secondField;
                }
                set
                {
                    this.secondField = value;
                }
            }

            /// <remarks/>
            public JeopardyCategoryThird third
            {
                get
                {
                    return this.thirdField;
                }
                set
                {
                    this.thirdField = value;
                }
            }

            /// <remarks/>
            public JeopardyCategoryFourth fourth
            {
                get
                {
                    return this.fourthField;
                }
                set
                {
                    this.fourthField = value;
                }
            }

            /// <remarks/>
            public JeopardyCategoryFifth fifth
            {
                get
                {
                    return this.fifthField;
                }
                set
                {
                    this.fifthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategoryFirst
        {

            private byte pointsField;

            private string answerField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte points
            {
                get
                {
                    return this.pointsField;
                }
                set
                {
                    this.pointsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategorySecond
        {

            private byte pointsField;

            private string answerField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte points
            {
                get
                {
                    return this.pointsField;
                }
                set
                {
                    this.pointsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategoryThird
        {

            private ushort pointsField;

            private string answerField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort points
            {
                get
                {
                    return this.pointsField;
                }
                set
                {
                    this.pointsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategoryFourth
        {

            private ushort pointsField;

            private string answerField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort points
            {
                get
                {
                    return this.pointsField;
                }
                set
                {
                    this.pointsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class JeopardyCategoryFifth
        {

            private ushort pointsField;

            private string answerField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort points
            {
                get
                {
                    return this.pointsField;
                }
                set
                {
                    this.pointsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }
        #endregion -- jeapordy object --

        /// <summary>
        /// this ends all processes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end of application


        #region --- BTN CLick events for game questions ---
        private void button1_Click(object sender, EventArgs e)
        {
            // display the appropriate text to the answer box
            //txtBxAnswer.Text = loadedObject.category[0].first.points.ToString();  // this is how to access stuff now.
            //XmlSerializer serializer = new XmlSerializer(typeof(Jeopardy));
            //FileStream loadStream = new FileStream("Jeopardy.xml", FileMode.Open, FileAccess.Read);
            //Jeopardy loadedObject = (Jeopardy)serializer.Deserialize(loadStream);
            //loadStream.Close();
            txtBxQuestion.Text = loadedObject.category[0].first.Value.ToString();
            whichBox = loadedObject.category[0].first.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[0].first.points);
            button1.Text = string.Empty;
            button1.Enabled = false;
            btnClick++;
        } // end of button1_Click

        private void button2_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[1].first.Value.ToString();
            whichBox = loadedObject.category[1].first.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[1].first.points);
            button2.Text = string.Empty;
            button2.Enabled = false;
            btnClick++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[2].first.Value.ToString();
            whichBox = loadedObject.category[2].first.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[2].first.points);
            button3.Text = string.Empty;
            button3.Enabled = false;
            btnClick++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[3].first.Value.ToString();
            whichBox = loadedObject.category[3].first.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[3].first.points);
            button4.Text = string.Empty;
            button4.Enabled = false;
            btnClick++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[4].first.Value.ToString();
            whichBox = loadedObject.category[4].first.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[4].first.points);
            button5.Text = string.Empty;
            button5.Enabled = false;
            btnClick++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[0].second.Value.ToString();
            whichBox = loadedObject.category[0].second.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[0].second.points);
            button6.Text = string.Empty;
            button6.Enabled = false;
            btnClick++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[1].second.Value.ToString();
            whichBox = loadedObject.category[1].second.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[1].second.points);
            button7.Text = string.Empty;
            button7.Enabled = false;
            btnClick++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[2].second.Value.ToString();
            whichBox = loadedObject.category[2].second.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[2].second.points);
            button8.Text = string.Empty;
            button8.Enabled = false;
            btnClick++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[3].second.Value.ToString();
            whichBox = loadedObject.category[3].second.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[3].second.points);
            button9.Text = string.Empty;
            button9.Enabled = false;
            btnClick++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[4].second.Value.ToString();
            whichBox = loadedObject.category[4].second.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[4].second.points);
            button10.Text = string.Empty;
            button10.Enabled = false;
            btnClick++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[0].third.Value.ToString();
            whichBox = loadedObject.category[0].third.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[0].third.points);
            button11.Text = string.Empty;
            button11.Enabled = false;
            btnClick++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[1].third.Value.ToString();
            whichBox = loadedObject.category[1].third.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[1].third.points);
            button12.Text = string.Empty;
            button12.Enabled = false;
            btnClick++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[2].third.Value.ToString();
            whichBox = loadedObject.category[2].third.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[2].third.points);
            button13.Text = string.Empty;
            button13.Enabled = false;
            btnClick++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[3].third.Value.ToString();
            whichBox = loadedObject.category[3].third.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[3].third.points);
            button14.Text = string.Empty;
            btnClick++;
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[4].third.Value.ToString();
            whichBox = loadedObject.category[4].third.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[4].third.points);
            button15.Text = string.Empty;
            button15.Enabled = false;
            btnClick++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[0].fourth.Value.ToString();
            whichBox = loadedObject.category[0].fourth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[0].fourth.points);
            button16.Text = string.Empty;
            button16.Enabled = false;
            btnClick++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[1].fourth.Value.ToString();
            whichBox = loadedObject.category[1].fourth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[1].fourth.points);
            button17.Text = string.Empty;
            button17.Enabled = false;
            btnClick++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[2].fourth.Value.ToString();
            whichBox = loadedObject.category[2].fourth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[2].fourth.points);
            button18.Text = string.Empty;
            button18.Enabled = false;
            btnClick++;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[3].fourth.Value.ToString();
            whichBox = loadedObject.category[3].fourth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[3].fourth.points);
            button19.Text = string.Empty;
            button19.Enabled = false;
            btnClick++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[4].fourth.Value.ToString();
            whichBox = loadedObject.category[4].fourth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[4].fourth.points);
            button20.Text = string.Empty;
            button20.Enabled = false;
            btnClick++;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[0].fifth.Value.ToString();
            whichBox = loadedObject.category[0].fifth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[0].fifth.points);
            button21.Text = string.Empty;
            button21.Enabled = false;
            btnClick++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[1].fifth.Value.ToString();
            whichBox = loadedObject.category[1].fifth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[1].fifth.points);
            button22.Text = string.Empty;
            button22.Enabled = false;
            btnClick++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[2].fifth.Value.ToString();
            whichBox = loadedObject.category[2].fifth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[2].fifth.points);
            button23.Text = string.Empty;
            button23.Enabled = false;
            btnClick++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[3].fifth.Value.ToString();
            whichBox = loadedObject.category[3].fifth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[3].fifth.points);
            button24.Text = string.Empty;
            button24.Enabled = false;
            btnClick++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            txtBxQuestion.Text = loadedObject.category[4].fifth.Value.ToString();
            whichBox = loadedObject.category[4].fifth.answer.ToString();
            points = Convert.ToDouble(loadedObject.category[4].fifth.points);
            button25.Text = string.Empty;
            button25.Enabled = false;
            btnClick++;
        }
        #endregion -- btnclick events --

        #region --- Current Player ---
        private void label1_Click(object sender, EventArgs e)
        {
            currentPlayer = 1;
            lblTest.Text = "Player:  " + conOne.Name.ToString();
            txtBxAnswer.Enabled = true;
            txtBxAnswer.Clear();
            //Player current = conOne;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            currentPlayer = 2;
            string pn = "Player: ";
            string fpn = conTwo.Name.ToString();
            lblTest.Text = string.Concat(pn,fpn);
            txtBxAnswer.Enabled = true;
            txtBxAnswer.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            currentPlayer = 3;
            lblTest.Text = "Player:  " + conThree.Name.ToString();
            txtBxAnswer.Enabled = true;
            txtBxAnswer.Clear();
        }

        #endregion -- current Player --

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // this need to compare text in txtBxAnswer with the component
            string ans = txtBxAnswer.Text;
            // whichBox is the string form of the answer sent in 
            
            string expression = whichBox.ToUpper();
            string quest1 = "WHAT";
            string quest2 = "WHO";
            if (IsValid(ans, expression))
            {
                if (IsValid(ans, quest1))
                {
                    // adjust score for player
                    //current.updateScore(points);
                    rightOrWrong(currentPlayer, points);
                    lblTest.Text = "Correct";
                    txtBxQuestion.Text = whichBox.ToUpper();
                    txtBxAnswer.Clear();
                    txtBxAnswer.Enabled = false;
                }
                if (IsValid(ans, quest2))
                {
                    rightOrWrong(currentPlayer, points);
                    lblTest.Text = "Correct";
                    txtBxQuestion.Text = whichBox.ToUpper();
                    txtBxAnswer.Clear();
                    txtBxAnswer.Enabled = false;
                } // end of if question
               // if not true then score gets deducted
            } // end of if true
            else
            {
                // score goes down for player
                points = points * -1;
                //lblTest.Text = points.ToString();
                rightOrWrong(currentPlayer, points);
                lblTest.Text = "InCorrect";
                txtBxAnswer.Clear();
                playersGuessed++;
            } // end of else
            //lblTest.Text = "";
            currentPlayer = -1;
            
            //txtBxQuestion.Clear();
            
            if (btnClick == 25 && playersGuessed == 3)
            {
                // who wins -- make a method for this and maybe do a form then end
                int winner = 0;
                if (conOne.Score < conTwo.Score)
                {
                    winner = 2;
                    if (conTwo.Score < conThree.Score)
                    {
                        winner = 3;
                    } // end of if
                } // end of if
                if ( conTwo.Score < conOne.Score)
                {
                    winner = 1;
                    if (conOne.Score < conThree.Score)
                    {
                        winner = 3;
                    } // end of if 
                } // end of if
                if ( conThree.Score < conOne.Score)
                {
                    winner = 1;
                    if (conOne.Score < conTwo.Score)
                    {
                        winner = 2;
                    } // end of if
                } // end of if
                switch (winner)
                {
                    case 1:
                        lblTest.Text = "Winner is: " + conOne.Name.ToString() + "with $ " + conOne.Score.ToString();
                        break;
                    case 2:
                        lblTest.Text = "Winner is: " + conTwo.Name.ToString() + "with $ " + conTwo.Score.ToString();
                        break;
                    case 3:
                        lblTest.Text = "Winner is: " + conThree.Name.ToString() + "with $ " + conThree.Score.ToString();
                        break;
                } // end of switch
                  // lblTest.Text = " Winner is: " + 
                btnCheckAnswer.Enabled = false;
                txtBxAnswer.Text = "To exit game click 'End Game' button";
                txtBxQuestion.Text = "To exit game click 'End Game' button";

            } // end of game wiiner is
        } // end of btnCheckAnswer_Click

        public void rightOrWrong(int who, double amnt)
        {
            if (who == 1)
            {
                conOne.updateScore(amnt);
                txtBxPlyr1Score.Text = conOne.Score.ToString();
            } // end of if
            if (who == 2)
            {
                conTwo.updateScore(amnt);
                txtBxPlyr2Score.Text = conTwo.Score.ToString();
            } // end of if
            if (who == 3)
            {
                conThree.updateScore(amnt);
                txtBxPlyr3Score.Text = conThree.Score.ToString();
            } // end of if
        } // end of rightOrWrong

        static bool IsValid(string value, string tester)
        {
            return Regex.IsMatch(value, tester);
        } // end of IsValid

        private void txtBxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void lblQ_Click(object sender, EventArgs e)
        {

        }

        private void txtBxAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    } // end of GameBoard From
} // end of namespace
