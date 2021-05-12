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
        private IndexedValueView view;
        private IndexedValueView pretres;
        private IndexedValueView mordred;
        private IndexedValueView prestige;
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
            strs.ForEach(str=>outputListBox.Items.Add(str));
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
                int index = 0;
                foreach (IndexedValue indexed in theWorld.Groups)
                {
                    view = new IndexedValueView(indexed, new Point(100*index,10), new Size(1, 1), 1, Color.Red, "Times New Roman");
                    view.Draw(e.Graphics);
                    index++;
                }
                index = 0;
                foreach (IndexedValue indexed in theWorld.Policies)
                {
                    view = new IndexedValueView(indexed, new Point(100 * index, 30), new Size(1, 1), 1, Color.Red, "Times New Roman");
                    view.Draw(e.Graphics);
                    index++;
                }
                index = 0;
                foreach (IndexedValue indexed in theWorld.Indicators)
                {
                    view = new IndexedValueView(indexed, new Point(100 * index, 50), new Size(1, 1), 1, Color.Red, "Times New Roman");
                    view.Draw(e.Graphics);
                    index++;
                }
                index = 0;
                foreach (IndexedValue indexed in theWorld.Perks)
                {
                    view = new IndexedValueView(indexed, new Point(100 * index, 70), new Size(1, 1), 1, Color.Red, "Times New Roman");
                    view.Draw(e.Graphics);
                    index++;
                }
                index = 0;
                foreach (IndexedValue indexed in theWorld.Crises)
                {
                    view = new IndexedValueView(indexed, new Point(100 * index, 90), new Size(1, 1), 1, Color.Red, "Times New Roman");
                    view.Draw(e.Graphics);
                    index++;
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
    }
}
