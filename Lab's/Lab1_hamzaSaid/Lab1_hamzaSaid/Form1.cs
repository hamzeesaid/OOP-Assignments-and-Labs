//*****************************************************************************
//Assignment         : CMPE2300 LAB

//Author             : Hamza Said

//Instructor         : Shane 

//Submission Code    : 1202_2300_L01

//Created Jan 29 2021
//*****************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GDIDrawer;
using System.IO;

namespace Lab1_hamzaSaid
{
    public partial class Form1 : Form
    {
        public delegate void ListMessage(string str);
        public delegate void ButtonText(string str);
        Thread thread;
        List<Box> _boxs = new List<Box>();      //List of te blocks 
        CDrawer canvas;                         //Drawer Window             
        List<Color> _boxcolor;                  //Color of the box 
        int fileAlloc;
        const int maxWidth = 1000;


        public Form1()
        {
            InitializeComponent();
            MakeColors();

        }


        /// <summary>
        /// Struck define the name of file , seq num and the index 
        /// </summary>
        struct Box
        {

            public string fName;
            public int seqNum;
            public int Index;
        }

        /// <summary>
        /// Load file from computer using openFileDialogue
        /// Real the file and using a split to seprate file name 
        /// sequesnce number and the index with a comma .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFile_Click(object sender, EventArgs e)
        {
            _boxs.Clear();

            OpenFileDialog fLoad = new OpenFileDialog();

            if (fLoad.ShowDialog() == DialogResult.OK)
            {

                string[] line = File.ReadAllLines(fLoad.FileName);


                foreach (string str in line)
                {
                    Box data;
                    string[] split = str.Split(' ');

                    data.fName = split[0];
                    data.seqNum = Convert.ToInt32(split[1]);
                    data.Index = Convert.ToInt32(split[2]);
                    _boxs.Add(data);

                }

                int _boxpopulate = (int)Math.Sqrt(line.Length);

                if (Math.Sqrt(line.Length) > _boxpopulate)
                {
                    _boxpopulate++;
                }


                fileAlloc = _boxpopulate;


                int width = (maxWidth / fileAlloc) * fileAlloc;
                int height = width / 4;

                //
                canvas = new CDrawer((height / fileAlloc) * 4 * fileAlloc, (height / fileAlloc) * fileAlloc);


                RenderUnits(_boxs, canvas, (height / fileAlloc));
            }

        }

        /// <summary>
        ///  It returns nothing and accepts nothing. It will be imported from
        /// builder will also fill out a Colors form list with a new list and complete the list
        /// </summary>
        private void MakeColors()
        {
            //populate new list 
            _boxcolor = new List<Color>();

            //fil the list with colors
            for (int i = 64; i <= 192; i += 64)
            {
                for (int j = 64; j <= 192; j += 64)
                {
                    for (int k = 64; k <= 192; k += 64)
                    {
                        _boxcolor.Add(Color.FromArgb(i, j, k));
                    }
                }
            }

        }


        /// <summary>
        ///  It returns nothing, accepts a List of file units, drawers, and file unit
        ///  height.Clear drawer, and then rate it in all file units.In other words, build
        ///  Rectangular object with appropriate X -axis, Y-axis(Grid Activity) Links, 4 times the width
        ///  height.If the file unit is empty, fill in the rectangle with gray. Alternatively, It use the character as
        ///  an offset (eg a is 0, b is 1, .. z = 25) fill in the rectangle with the color shown in our color list.
        /// </summary>
        /// <param name="blocks"></param>
        /// <param name="canvas"></param>
        /// <param name="height"></param>
        private void RenderUnits(List<Box> blocks, CDrawer canvas, int height)
        {
            //clear the canvas.
            canvas.Clear();

            Rectangle rec = new Rectangle();


            for (int i = 0; i < blocks.Count(); ++i)
            {

                rec.X = ((i % fileAlloc) * 4 * height);
                rec.Y = ((i / fileAlloc) * height);
                rec.Width = height * 4;
                rec.Height = height;

                int val = 0;
                foreach (char c in blocks[i].fName)
                {
                    val = c - 'a';
                }


                //gray color to the box if the box is empty

                if (blocks[i].Index == -1)
                {
                    canvas.AddRectangle(rec.X, rec.Y, rec.Width, rec.Height, Color.Gray, 2, Color.Gray);
                }

                else
                {
                    
                    canvas.AddRectangle(rec.X, rec.Y, rec.Width, rec.Height, _boxcolor[val], 2, Color.Yellow);

                    //Add data value in the block
                    canvas.AddText(blocks[i].fName + ": " + Convert.ToString(blocks[i].seqNum) + ": " + Convert.ToString(blocks[i].Index), 8, rec.X, rec.Y, rec.Width, rec.Height, Color.White);
                }
            }

            canvas.Render();
        }


        /// <summary>
        /// Method is used to check that the files are error free .
        /// check the given requirements and return an error messag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifyFile_Click(object sender, EventArgs e)
        {
            Box itemp;
            int k;

            int Erorr = 0;
            List<Box> value = new List<Box>();
            string letter = "a";


            for (int i = 0; i < 26; ++i)
            {

                for (int j = 0; j < _boxs.Count; ++j)
                {

                    if (_boxs[j].fName == letter)
                    {
                        value.Add(_boxs[j]);


                        if (_boxs[j].Index > _boxs.Count - 2)
                        {
                            listView1.Items.Add("ERROR: Index was out of bounds in " + _boxs[j].fName + ": " + _boxs[j].seqNum + ": " + _boxs[j].Index + ".");
                            Erorr++;
                        }
                    }
                }


                for (int a = 1; a < value.Count; ++a)
                {
                    itemp = value[a];
                    k = a - 1;

                    while (k >= 0 && value[k].seqNum > itemp.seqNum)
                    {
                        value[k + 1] = value[k];
                        k--;
                    }
                    value[k + 1] = itemp;
                }


                if (value.Count >= 1)
                {

                    Erorr += OrderCheck(value);


                    if (value[0].seqNum != 0)
                    {
                        listView1.Items.Add("ERROR:There is not starting element for file name " + letter);
                        Erorr++;
                    }


                    if (value[value.Count - 1].Index != -2)
                    {
                        listView1.Items.Add("ERROR:There is not ending element for file name " + letter);
                        Erorr++;
                    }


                    
                }

                value.Clear();


                letter = ((char)((int)letter[0] + 1)).ToString();
            }

            if (Erorr == 0)
            {
                listView1.Items.Add("No Errors Found.");
            }
        }

        private int OrderCheck(List<Box> arr)
        {
            int _ierror = 0;


            for (int i = 0; i < arr.Count; i++)
            {

                if (i + 1 < arr.Count && arr[i].seqNum + 1 != arr[i + 1].seqNum)
                {
                    listView1.Items.Add("ERROR:Item are not in sequence starting from " + arr[i].fName + ":" + arr[i].seqNum + ":" + arr[i].Index);
                    _ierror++;
                    break;
                }
            }
            return _ierror;
        }


        /// <summary>    
        ///  It returns the value representing the empty index found, accepting the file list
        ///  units, and a checkbox if the search should start in the middle of the list - It set a
        /// the default number of lies. 
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="halfway"></param>
        /// <returns></returns>

        private int FirstEmpty(List<Box> elements, bool halfway = false)
        {
            int num = 0;

            //If list is already started then it will start from midway
            if (halfway == true)
            {
                num = (elements.Count / 2) - 1;
            }


            while (num < elements.Count)
            {
                //Returns the index of the empty block spot
                if (elements[num].Index == -1)
                {
                    return num;
                }

                ++num;
            }

            return -1;
        }


        private void MoveUnit(List<Box> blocks, int TheBlock, int MoveTO)
        {
            Box temp;


            for (int i = 0; i < blocks.Count; ++i)
            {
                if (blocks[i].Index == TheBlock)
                {

                    temp.fName = blocks[i].fName;
                    temp.seqNum = blocks[i].seqNum;
                    temp.Index = MoveTO;


                    blocks.RemoveAt(i);


                    blocks.Insert(i, temp);
                }
            }

        }


        private int NeedDefrag(List<Box> boxs)
        {
            string iLetterCheck;

            for (int i = 0; i < boxs.Count; ++i)
            {

                if (!int.TryParse(boxs[i].fName, out int n) && boxs[i].seqNum == 0)
                {

                    iLetterCheck = boxs[i].fName;


                    if (boxs[i].Index != i + 1)
                    {
                        return i + 1;
                    }

                    else
                    {
                        for (int j = i + 1; j < boxs.Count; ++j)
                        {
                            if (boxs[j].Index != -2 && boxs[j].fName == iLetterCheck && j + 1 < boxs.Count)
                            {
                                if (boxs[j].Index != j + 1)
                                {
                                    return j + 1;
                                }

                            }

                            else if (boxs[j].Index != -2 && boxs[j].fName == iLetterCheck && j + 1 >= boxs.Count)
                            {
                                return i;
                            }
                        }
                    }
                }
            }

            return -3;
        }


        private void DefragFile_Click(object sender, EventArgs e)
        {
            if (thread != null)

            {
                thread.Abort();
                thread = null;

                listView1.Items.Add("Defrag:Thread terminated");
                DefragFile.Text = "Defrag Filesystem";
            }

            else
            {

                thread = new Thread(Defrag);
                thread.IsBackground = true;

                DefragFile.Text = "Cancel Defragmentation";
                thread.Start(_boxs);
            }
        }


        private void Defrag(object obj)
        {
            List<Box> Defragmentation = (List<Box>)obj;
            int iEmptyPos = 0;
            bool mid = true;
            int index = 0;


            do
            {
                if (DefragOrderCheck(Defragmentation) != 0)
                {
                    Thread.Sleep(250);


                    index = NeedDefrag(Defragmentation);
                    iEmptyPos = FirstEmpty(Defragmentation, mid);


                    if (index == Defragmentation.Count - 1)
                    {
                        mid = false;
                    }


                    if (index != -3 || iEmptyPos == -1)
                    {

                        MoveUnit(Defragmentation, index, iEmptyPos);

                        int blockcount = (int)Math.Sqrt(Defragmentation.Count);

                        if (Math.Sqrt(Defragmentation.Count) > blockcount)
                        {
                            blockcount++;
                        }

                        int width = (maxWidth / blockcount) * blockcount;
                        int height = width / 4;


                        RenderUnits(Defragmentation, canvas, (height / blockcount));

                        if (Defragmentation[index - 1].Index != -1)
                        {
                            Thread.Sleep(250);


                            MoveUnit(Defragmentation, Defragmentation[index - 1].Index, index);


                            blockcount = (int)Math.Sqrt(Defragmentation.Count);

                            if (Math.Sqrt(Defragmentation.Count) > blockcount)
                            {
                                blockcount++;
                            }

                            width = (maxWidth / blockcount) * blockcount;
                            height = width / 4;


                            RenderUnits(Defragmentation, canvas, (height / blockcount));
                        }
                    }
                }
                else
                {
                    thread = null;
                }
            } while (thread != null);

            
        }

        private int DefragOrderCheck(List<Box> arr)
        {
            //checks each letter
            string iletter = "a";


            int OrderCheck = 0;


            for (int i = 0; i < 26; ++i)
            {

                for (int j = 0; j < arr.Count; ++j)
                {

                    if (j + 1 < arr.Count && arr[j].Index != -2)
                    {
                        if ((arr[j].fName != arr[j + 1].fName) && (arr[j].seqNum + 1 != arr[j + 1].seqNum))
                        {
                            OrderCheck++;
                        }
                    }
                }


                iletter = ((char)(iletter[0] + 1)).ToString();
            }


            return OrderCheck;
        }

    }
}
    
