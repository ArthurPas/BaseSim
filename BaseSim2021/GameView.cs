using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BaseSim2021
{
    public partial class GameView : Form
    {
        private readonly WorldState theWorld;
        List<IndexedValueView> polViews;
        List<IndexedValueView> grpViews;
        List<IndexedValueView> indViews;
        List<IndexedValueView> perksViews;
        List<IndexedValueView> crisesViews;

        /// <summary>
        /// The constructor for the main window
        /// </summary>
        public GameView(WorldState world)
        {
            InitializeComponent();


            theWorld = world;
        }
        /// <summary>
        /// Method called by the controler whenever some text should be displayed
        /// </summary>
        /// <param name="s"></param>
        public void WriteLine(string s)
        {
            List<string> strs = s.Split('\n').ToList();
            strs.ForEach(str => outputListBox.Items.Add(str));
            if (outputListBox.Items.Count > 0)
            {
                outputListBox.SelectedIndex = outputListBox.Items.Count - 1;
            }
            outputListBox.Refresh();
        }
        /// <summary>
        /// Method called by the controler whenever a confirmation should be asked
        /// </summary>
        /// <returns>Yes iff confirmed</returns>
        public bool ConfirmDialog()
        {
            string message = "Confirmer ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, "", buttons) == DialogResult.Yes;
        }
        #region Event handling
        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Or beep.
                GameController.Interpret(inputTextBox.Text);
            }
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            if (theWorld.Values != null)
            {
                Rectangle PolRectangle = new Rectangle(0, 0, 2100, 300);
                Rectangle GrpRectangle = new Rectangle(0, 100, 2100, 300);
                Rectangle IndRectangle = new Rectangle(0, 200, 2100, 300);
                Rectangle PerksRectangle = new Rectangle(0, 300, 2100, 300);
                Rectangle CrisesRectangle = new Rectangle(0, 400, 2100, 300);
                int margin = 5;
                int w = 80;
                int h = 80;
                int xPol = PolRectangle.X + margin, yPol = PolRectangle.Y + margin;
                int xGrp = GrpRectangle.X + margin, yGrp = GrpRectangle.Y + margin;
                int xInd = IndRectangle.X + margin, yInd = IndRectangle.Y + margin;
                int xPer = PerksRectangle.X + margin, yPer = PerksRectangle.Y + margin;
                int xCri = CrisesRectangle.X + margin, yCri = CrisesRectangle.Y + margin;
                polViews = new List<IndexedValueView>();
                grpViews = new List<IndexedValueView>();
                indViews = new List<IndexedValueView>();
                perksViews = new List<IndexedValueView>();
                crisesViews = new List<IndexedValueView>();
                foreach (IndexedValue p in theWorld.Policies)
                {

                    polViews.Add(new IndexedValueView(p, new Point(xPol, yPol), new Size(w, h), Color.Aqua));
                    xPol += w + margin;
                    if (xPol > PolRectangle.Right)
                    {

                        xPol = PolRectangle.X;
                        yPol += h + margin;
                    }

                }
                foreach (IndexedValue p in theWorld.Groups)
                {
                    grpViews.Add(new IndexedValueView(p, new Point(xGrp, yGrp), new Size(w, h), Color.BlueViolet));
                    xGrp += w + margin;
                    if (xGrp > GrpRectangle.Right)
                    {

                        xGrp = GrpRectangle.X;
                        yGrp += h + margin;
                    }

                }
                foreach (IndexedValue p in theWorld.Indicators)
                {
                    indViews.Add(new IndexedValueView(p, new Point(xInd, yInd), new Size(w, h), Color.OrangeRed));
                    xInd += w + margin;
                    if (xInd > IndRectangle.Right)
                    {

                        xInd = IndRectangle.X;
                        yInd += h + margin;
                    }

                }
                foreach (IndexedValue p in theWorld.Perks)
                {
                    perksViews.Add(new IndexedValueView(p, new Point(xPer, yPer), new Size(w, h), Color.Red));
                    xPer += w + margin;
                    if (xPer > PerksRectangle.Right)
                    {

                        xPer = PerksRectangle.X;
                        yPer += h + margin;
                    }

                }
                foreach (IndexedValue p in theWorld.Crises)
                {
                    crisesViews.Add(new IndexedValueView(p, new Point(xCri, yCri), new Size(w, h), Color.Brown));
                    xCri += w + margin;
                    if (xCri > CrisesRectangle.Right)
                    {

                        xCri = CrisesRectangle.X;
                        yCri += h + margin;
                    }

                }
                foreach (IndexedValueView indexed in polViews)
                {
                    indexed.Draw(e.Graphics);
                }
                foreach (IndexedValueView indexed in grpViews)
                {
                    indexed.Draw(e.Graphics);
                }
                foreach (IndexedValueView indexed in indViews)
                {
                    indexed.Draw(e.Graphics);
                }
                foreach (IndexedValueView indexed in perksViews)
                {
                    indexed.Draw(e.Graphics);
                }
                foreach (IndexedValueView indexed in crisesViews)
                {
                    indexed.Draw(e.Graphics);
                }
                diffLabel.Text = "Difficulté : " + theWorld.TheDifficulty;
                turnLabel.Text = "Tour " + theWorld.Turns;
                moneyLabel.Text = "Trésor : " + theWorld.Money + " pièces d'or";
                gloryLabel.Text = "Gloire : " + theWorld.Glory;

                nextButton.Visible = true;
            }
        }
        #endregion

        private void NextButton_Click(object sender, EventArgs e)
        {
            GameController.Interpret("suivant");
        }
        public void LoseDialog(IndexedValue indexedValue)
        {
            if (indexedValue == null)
            {
                MessageBox.Show("Partie perdue : dette insurmontable.");
            }
            else
            {
                MessageBox.Show("Partie perdue :"
                + indexedValue.CompletePresentation());
            }
            nextButton.Enabled = false;
        }
        public void WinDialog()
        {
            MessageBox.Show("Partie gagnée !");
            nextButton.Enabled = false;
        }

        private void winButtonDebug_Click(object sender, EventArgs e)
        {
            GameController.Interpret("politique gardes 100");
            GameController.Interpret("politique pretres 100");
            GameController.Interpret("politique impots 40");
            GameController.Interpret("suivant");
            GameController.Interpret("politique subventions 100");
            GameController.Interpret("politique quetegraal 10");
            GameController.Interpret("suivant");
            GameController.Interpret("politique ecoles 100");
            GameController.Interpret("politique enchanteurs 100");
            GameController.Interpret("politique  taxeluxe 10");
            GameController.Interpret("suivant");
            GameController.Interpret("politique theatres 100");
            GameController.Interpret("politique taxealcool 5");
            GameController.Interpret("politique agrandirterritoires 2");
            GameController.Interpret("politique monstres 2");
            GameController.Interpret("suivant");
            GameController.Interpret("suivant");
            GameController.Interpret("politique thermes 100");
            GameController.Interpret("politique juges 100");
            GameController.Interpret("politique taxefonciere 5");
            GameController.Interpret("politique dragons 5");

        }

        private void GameView_MouseDown(object sender, MouseEventArgs e)
        {
            string name, desc;
            int value, maxValue, minValue;
            foreach (IndexedValueView politics in polViews)
            {
                if (politics.Contains(e.Location))
                {
                    name = politics.IndexedValue.Name;
                    value = politics.IndexedValue.Value;
                    minValue = politics.IndexedValue.MinValue;
                    maxValue = politics.IndexedValue.MaxValue;
                    desc = politics.IndexedValue.Description;
                    Modif modif = new Modif(name, value, maxValue, minValue, desc);
                    modif.Show();

                }
            }
            foreach (IndexedValueView perks in perksViews)
            {
                if (perks.Contains(e.Location))
                {
                    name = perks.IndexedValue.Name;
                    value = perks.IndexedValue.Value;
                    minValue = perks.IndexedValue.MinValue;
                    maxValue = perks.IndexedValue.MaxValue;
                    desc = perks.IndexedValue.Description;
                    Modif modif = new Modif(name, value, maxValue, minValue, desc);
                    modif.Show();
                }
            }
            foreach (IndexedValueView grp in grpViews)
            {
                if (grp.Contains(e.Location))
                {
                    name = grp.IndexedValue.Name;
                    value = grp.IndexedValue.Value;
                    minValue = grp.IndexedValue.MinValue;
                    maxValue = grp.IndexedValue.MaxValue;
                    desc = grp.IndexedValue.Description;
                    Modif modif = new Modif(name, value, maxValue, minValue, desc);
                    modif.Show();
                }
            }
            foreach (IndexedValueView indicators in indViews)
            {
                if (indicators.Contains(e.Location))
                {
                    name = indicators.IndexedValue.Name;
                    value = indicators.IndexedValue.Value;
                    minValue = indicators.IndexedValue.MinValue;
                    maxValue = indicators.IndexedValue.MaxValue;
                    desc = indicators.IndexedValue.Description;
                    Modif modif = new Modif(name, value, maxValue, minValue, desc);
                    modif.Show();

                }
            }
            foreach (IndexedValueView crises in crisesViews)
            {
                if (crises.Contains(e.Location))
                {
                    name = crises.IndexedValue.Name;
                    value = crises.IndexedValue.Value;
                    minValue = crises.IndexedValue.MinValue;
                    maxValue = crises.IndexedValue.MaxValue;
                    desc = crises.IndexedValue.Description;
                    Modif modif = new Modif(name, value, maxValue, minValue, desc);
                    modif.Show();
                }
            }
        }

    }
}
