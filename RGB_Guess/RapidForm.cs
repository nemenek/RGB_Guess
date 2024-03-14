using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Guess
{
    public enum ColorOrder
    {
        RedGreenBlue,
        RedBlueGreen,
        GreenRedBlue,
        GreenBlueRed,
        BlueRedGreen,
        BlueGreenRed
    }
    public partial class RapidForm : Form
    {

        private BindingList<string> items;

        private short Red { get; set; }
        private short Green { get; set; }
        private short Blue { get; set; }

        private int HighScore;

        private ColorOrder Order;

        private int round;

        public RapidForm()
        {
            InitializeComponent();
            this.HighScore = ReadHighScore();
            round = 1;
            do
            {
                ColorPanel.BackColor = ColorGenerator.GenerateColor();
            } while (ColorPanel.BackColor.R == ColorPanel.BackColor.G || ColorPanel.BackColor.R == ColorPanel.BackColor.B || ColorPanel.BackColor.G == ColorPanel.BackColor.B);
            setColorValues();
            InitializeComponentListBox();
        }
        private void setColorValues()
        {
            this.Red = ColorPanel.BackColor.R;
            this.Green = ColorPanel.BackColor.G;
            this.Blue = ColorPanel.BackColor.B;

            this.Order = GetColorOrder(Red, Green, Blue);
        }

        private ColorOrder GetColorOrder(short Red, short Green, short Blue)
        {
            switch ((Red < Green, Red < Blue, Green < Blue))
            {
                case (false, false, false):
                    return ColorOrder.RedGreenBlue;
                case (false, false, true):
                    return ColorOrder.RedBlueGreen;
                case (true, false, false):
                    return ColorOrder.GreenRedBlue;
                case (true, true, false):
                    return ColorOrder.GreenBlueRed;
                case (false, true, true):
                    return ColorOrder.BlueRedGreen;
                case (true, true, true):
                    return ColorOrder.BlueGreenRed;
                default:
                    throw new InvalidOperationException("Invalid color order");
            }
        }


        private void InitializeComponentListBox()
        {
            this.items = new BindingList<string>
            {
                "Red",
                "Green",
                "Blue"
            };
            listBox1.DataSource = items;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index>=0)
            {
                // Get the text of the item
                string text = listBox1.Items[e.Index].ToString();

                // Determine the color based on the text or index
                Color color;
                if (text == "Red")
                    color = Color.Red;
                else if (text == "Green")
                    color = Color.Green;
                else if (text == "Blue")
                    color = Color.Blue;
                else
                    color = Color.Black; // Default color

                // Set the background color and text color
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                
                e.Graphics.DrawString(text, e.Font, new SolidBrush(color), e.Bounds);

                // If the item is selected, draw the focus rectangle
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.DrawFocusRectangle();
            }
        }

        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the drop point
            int newIndex = listBox1.IndexFromPoint(listBox1.PointToClient(new Point(e.X, e.Y)));

            // Get the dragged item
            string draggedItem = (string)e.Data.GetData(typeof(string));

            // Remove the item from its original position in the data source
            this.items.Remove(draggedItem);

            // Insert the item at the drop point in the data source
            if (newIndex != ListBox.NoMatches)
            {
                this.items.Insert(newIndex, draggedItem);
            }
            else
            {
                this.items.Add(draggedItem);
            }

            

            // Rebind the updated data source to the ListBox
            //listBox1.DataSource = this.items; // Clear the ListBox's data source
            //listBox1.Refresh();
            //listBox1.DataSource = (List<string>)listBox1.DataSource; // Reassign the updated data source
        }


        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Start drag-and-drop operation when an item is clicked
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = listBox1.Items[index].ToString();
                listBox1.DoDragDrop(selectedItem, DragDropEffects.Move);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse((items[0] + items[1] + items[2]), out ColorOrder orderResult))
            {
                // Conversion succeeded, 'submittedOrder' contains the enum value
                Console.WriteLine("Converted to enum: " + orderResult);
            }
            else
            {
                // Conversion failed
                Console.WriteLine("Invalid input");
            }

            if(orderResult == this.Order)
            {
                resultLabel.Text = "Correct!";
                resultLabel.ForeColor = Color.Green;
                resultLabel.Visible = true;
                round++;
            }
            else
            {
                resultLabel.Text = "Incorrect!";
                resultLabel.ForeColor = Color.Red;
                resultLabel.Visible = true;
                RapidResult result = new RapidResult(round - 1);
                result.ShowDialog();
                if(HighScore < (round - 1))
                {
                    SetHighScore(round - 1);
                }
                round = 1;
            }

            greenVal.Text = Green.ToString();
            redVal.Text = Red.ToString();
            blueVal.Text = Blue.ToString();

            SubmitBtn.Enabled = false;
            NextBtn.Enabled = true;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = false;
            roundCtr.Text = this.round.ToString();
            do
            {
                ColorPanel.BackColor = ColorGenerator.GenerateColor();
            } while (ColorPanel.BackColor.R == ColorPanel.BackColor.G || ColorPanel.BackColor.R == ColorPanel.BackColor.B || ColorPanel.BackColor.G == ColorPanel.BackColor.B);
            
            setColorValues();

            greenVal.Text = 0.ToString();
            redVal.Text = 0.ToString();
            blueVal.Text = 0.ToString();

            SubmitBtn.Enabled = true;
            NextBtn.Enabled = false;
        }

        private int ReadHighScore()
        {
            int number = 0;
            if (File.Exists("highscoreRapid.txt"))
            {
                using (StreamReader reader = new StreamReader("highscoreRapid.txt"))
                {
                    string line = reader.ReadLine();
                    if (int.TryParse(line, out number))
                    {
                        // Number successfully parsed
                        return number;
                    }
                }
            }
            else
            {
                File.Create("highscoreRapid.txt").Close();
            }

            return number;
        }

        private void SetHighScore(int number)
        {
            using (StreamWriter writer = new StreamWriter("highscoreRapid.txt"))
            {
                writer.WriteLine(number);
            }
        }
    }
}
