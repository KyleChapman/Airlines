// Author: Kyle Chapman
// Date: March 22, 2022
// Description:
// This does stuff and is incomplete.

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

namespace Airlines
{
    public partial class Airlines : Form
    {
        List<string> airlineList = new List<string> { "Air Canada", "Qantas" };

        public Airlines()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Attempts to add the contents of the textbox on the form into the list(box?).
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // If the ListBox already includes the airline, report an error and don't add it to the list.
            if (listBoxAirlines.Items.Contains(textBoxAirlineEntry.Text.Trim()))
            {
                MessageBox.Show(textBoxAirlineEntry.Text + " is already on the list of airlines.");
            }
            // If the textbox is blank, report an error and don't add anything.
            else if (textBoxAirlineEntry.Text.Trim() == String.Empty)
            {
                MessageBox.Show("You must enter some kind of text for the airline.");
            }
            // If the airline is new and non-empty, add it to the list.
            else
            {
                airlineList.Add(textBoxAirlineEntry.Text.Trim());
                listBoxAirlines.Items.Add(textBoxAirlineEntry.Text.Trim());
                textBoxAirlineEntry.Clear(); 
            }    
        }

        /// <summary>
        /// Attempt to remove the selected item from the listBox.
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxAirlines.SelectedIndex >= 0)
            {
                airlineList.RemoveAt(listBoxAirlines.SelectedIndex);
                listBoxAirlines.Items.Remove(listBoxAirlines.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select an airline to remove.");
            }
            
        }

        /// <summary>
        /// This sorts our local list of airlines, clears the ListBox, and then adds our airlines into the ListBox one-by-one.
        /// </summary>
        private void buttonSort_Click(object sender, EventArgs e)
        {
            airlineList.Sort();
            listBoxAirlines.Items.Clear();

            foreach (string airline in airlineList)
            {
                listBoxAirlines.Items.Add(airline);
            }
        }

        /// <summary>
        /// Saves the current list to a text file in a default location.
        /// </summary>
        private void SaveClick(object sender, EventArgs e)
        {
            // Declare, instantiate and configure a new SaveFileDialog.
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = "List" + DateTime.Now.ToString("yyyyMMdd") + ".alf";
            saveDialog.Filter = "Airline Lists (*.alf)|*.alf|Comma separated value (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            
            // If the person picks a file and clicks "OK", continue processing.
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Create some System.IO objects to make file access easier.
                FileStream fileToAccess = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileToAccess);

                // If the filetype is .csv, prepare it as a comma separated value.
                if (saveDialog.FilterIndex == 2)
                {
                    // Count through the list
                    for (int index = 0; index < airlineList.Count; index++)
                    {
                        // Write the current item in the list into the file.
                        writer.Write(airlineList[index].ToString() + ", value!, something" + "\n");
                    }
                }
                // If the filetype ISN'T .csv.
                else
                {
                    // Count through the list
                    for (int index = 0; index < airlineList.Count; index++)
                    {
                        // Write the current item in the list into the file.
                        writer.Write(airlineList[index].ToString() + "\n");
                    }
                }

                // Close the file.
                writer.Close();

                MessageBox.Show("Your work is saved to " + saveDialog.FileName);
            }
            // The person didn't pick a file.
            else
            {
                MessageBox.Show("We didn't save anything. :(");
            }
        }

        /// <summary>
        /// This will prompt the user to confirm they want to overwrite their list, then it picks a file and overwrites their list.
        /// </summary>
        private void ImportClick(object sender, EventArgs e)
        {
            // Confirm that you want to overwrite.
            if (MessageBox.Show("This action will overwrite your current list. Are you sure?", "Overwrite Data?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Make a new OpenFileDialog and set its filter.
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Airline Lists (*.alf)|*.alf";

                // If the user has picked a file...
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    // Declare System.IO objects to write to that file.
                    FileStream fileToAccess = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fileToAccess);

                    // Clear the lists.
                    airlineList.Clear();
                    listBoxAirlines.Items.Clear();

                    // Read until the end of the file and fill those lines into the list.
                    while (!reader.EndOfStream)
                    {
                        string newAirline = reader.ReadLine();

                        airlineList.Add(newAirline);
                        listBoxAirlines.Items.Add(newAirline);
                    }

                    reader.Close();
                }
            }
            // Confirm with the user if they don't want to overwrite their list.
            else
            {
                MessageBox.Show("Okay, relax. We're not doing it.");
            }
        }
    }
}
