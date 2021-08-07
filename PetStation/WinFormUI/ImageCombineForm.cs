using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.FolderName;
using WinFormUI.ImageCombines;
using WinFormUI.ImagesResize;
using WinFormUI.Models;

namespace WinFormUI
{
    public partial class ImageCombineForm : Form
    {
        public ImageCombineForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(570, 0);
        }



        private void ImageCombineForm_Load(object sender, EventArgs e)
        {
            LoadListView();
            LoadLabelText();
            LoadAutoComboBoxItems();
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            try
            {


                var ImageandFileRoad = OpenFileDialogImage();

                if (ImageandFileRoad.Count == 1)
                {
                    foreach (var item in ImageandFileRoad)
                    {
                        pictureBox1.Image = item.Image;
                    }
                    var imageHeight = pictureBox1.Image.Height;
                    var imageWidth = pictureBox1.Image.Width;

                    lblHeight.Text = $"{imageHeight.ToString()} px.";
                    lblWitdh.Text = $"{imageWidth.ToString()} px.";
                }
                else
                {
                    MessageBox.Show("Tek resim seçebilirsiniz!");
                }



            }
            catch (Exception exception)
            {
                if (exception.Source == "mscorlib" && exception.Message == "Yol geçerli bir biçimde değil.")
                {
                    MessageBox.Show("Lütfen geçerli bir resim yolu belirtiniz.");
                }


            }


        }

        private void ResizeImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = false;
                if (textBoxHeight.Text == "" || textBoxWitdh.Text == "")
                {
                    MessageBox.Show("Yükseklik ve Genişlik alanları boş geçilemez.");
                }
                else
                {
                    int witdh = Convert.ToInt32(textBoxWitdh.Text);
                    int height = Convert.ToInt32(textBoxHeight.Text);

                    var image = pictureBox1.Image;

                    var newImage = ImageResize.ResizeImage(image, witdh, height);

                    SaveFileDialog saveNewImage = new SaveFileDialog();
                    saveNewImage.Filter = "Images|*.png;*.bmp;*.jpg";
                    ImageFormat format = ImageFormat.Jpeg;
                    if (saveNewImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string ext = System.IO.Path.GetExtension(saveNewImage.FileName);
                        switch (ext)
                        {
                            case ".jpg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                        }
                        newImage.Save(saveNewImage.FileName, format);
                        isValid = true;
                    }

                    if (isValid == true)
                    {
                        ClearPropertyForImage();
                        MessageBox.Show("Görsel başarılı bir şekilde boyutlandırıldı.");
                    }
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void ClearPropertyForImage()
        {
            textBoxHeight.Text = "";
            textBoxWitdh.Text = "";
        }

        private void LoadLabelText()
        {
            lblHeight.Text = "";
            lblWitdh.Text = "";
            lblCombinCountText.Text = "0";
            textBox1.Text = "";
            textBox1.ReadOnly = true;
            textBox1.BorderStyle = 0;
            textBox1.BackColor = Color.White;
            textBox1.TabStop = false;
            textBox2.Text = "";
            textBox2.ReadOnly = true;
            textBox2.BorderStyle = 0;
            textBox2.BackColor = Color.White;
            textBox2.TabStop = false;
            textBox3.Text = "";
            textBox3.ReadOnly = true;
            textBox3.BorderStyle = 0;
            textBox3.BackColor = Color.White;
            textBox3.TabStop = false;
            textBox4.Text = "";
            textBox4.ReadOnly = true;
            textBox4.BorderStyle = 0;
            textBox4.BackColor = Color.White;
            textBox4.TabStop = false;
            textBox5.Text = "";
            textBox5.ReadOnly = true;
            textBox5.BorderStyle = 0;
            textBox5.BackColor = Color.White;
            textBox5.TabStop = false;
            textBox6.Text = "";
            textBox6.ReadOnly = true;
            textBox6.BorderStyle = 0;
            textBox6.BackColor = Color.White;
            textBox6.TabStop = false;
            textBox7.Text = "";
            textBox7.ReadOnly = true;
            textBox7.BorderStyle = 0;
            textBox7.BackColor = Color.White;
            textBox7.TabStop = false;
            textBox8.Text = "";
            textBox8.ReadOnly = true;
            textBox8.BorderStyle = 0;
            textBox8.BackColor = Color.White;
            textBox8.TabStop = false;
            textBoxx9.Text = "";
            textBoxx9.ReadOnly = true;
            textBoxx9.BorderStyle = 0;
            textBoxx9.BackColor = Color.White;
            textBoxx9.TabStop = false;
            textBoxx10.Text = "";
            textBoxx10.ReadOnly = true;
            textBoxx10.BorderStyle = 0;
            textBoxx10.BackColor = Color.White;
            textBoxx10.TabStop = false;
            textBoxx11.Text = "";
            textBoxx11.ReadOnly = true;
            textBoxx11.BorderStyle = 0;
            textBoxx11.BackColor = Color.White;
            textBoxx11.TabStop = false;
            textBoxx12.Text = "";
            textBoxx12.ReadOnly = true;
            textBoxx12.BorderStyle = 0;
            textBoxx12.BackColor = Color.White;
            textBoxx12.TabStop = false;
            textBoxx13.Text = "";
            textBoxx13.ReadOnly = true;
            textBoxx13.BorderStyle = 0;
            textBoxx13.BackColor = Color.White;
            textBoxx13.TabStop = false;
            textBoxx14.Text = "";
            textBoxx14.ReadOnly = true;
            textBoxx14.BorderStyle = 0;
            textBoxx14.BackColor = Color.White;
            textBoxx14.TabStop = false;
            textBoxx15.Text = "";
            textBoxx15.ReadOnly = true;
            textBoxx15.BorderStyle = 0;
            textBoxx15.BackColor = Color.White;
            textBoxx15.TabStop = false;
            textBoxx16.Text = "";
            textBoxx16.ReadOnly = true;
            textBoxx16.BorderStyle = 0;
            textBoxx16.BackColor = Color.White;
            textBoxx16.TabStop = false;

        }

        private void AddForImageBtn_Click(object sender, EventArgs e)
        {
            var ImageandFileRoad = OpenFileDialogImage();


            if (ImageandFileRoad.Count == 0)
            {
                MessageBox.Show("Dosya yolu seçilmediğinden ekleme işlemi gerçekleştirilemez.");
            }
            else
            {
                foreach (var item in ImageandFileRoad)
                {

                    string fileName = FileName.InfoForFileName(item.FileRoad.ToString());
                    string[] words = fileName.Split('.');
                    string[] items = { item.FileRoad.ToString(), words[0].ToString() };
                    var row = new ListViewItem(items);
                    CombineImageListView.Items.Add(row);
                }

                lblCombinCountText.Text = CombineImageListView.Items.Count.ToString();

            }

        }

        private List<OpenFileDialogListModel> OpenFileDialogImage()
        {
            List<OpenFileDialogListModel> ImageandFileRoad = new List<OpenFileDialogListModel>();
            try
            {
                OpenFileDialog imageFile = new OpenFileDialog();



                imageFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                imageFile.Title = "Resim Dosyası Seç";
                imageFile.Multiselect = true;
                imageFile.ShowDialog();
                string[] fileRoad = imageFile.FileNames;


                if (fileRoad.Count() == 0)
                {
                    MessageBox.Show("Lütfen geçerli bir resim yolu belirtiniz.");
                }
                else if (fileRoad.Count() == 1)
                {
                    Bitmap image = new Bitmap(fileRoad[0]);
                    var ImageandFileRoadforList = new OpenFileDialogListModel
                    {
                        Image = image,
                        FileRoad = fileRoad[0]
                    };

                    ImageandFileRoad.Add(ImageandFileRoadforList);
                    return ImageandFileRoad;
                }
                else
                {
                    for (int i = 0; i < fileRoad.Count(); i++)
                    {
                        Bitmap image = new Bitmap(fileRoad[i]);
                        var ImageandFileRoadforList = new OpenFileDialogListModel
                        {
                            Image = image,
                            FileRoad = fileRoad[i]
                        };

                        ImageandFileRoad.Add(ImageandFileRoadforList);
                    }
                    var ProductsName = ReadListViewSecondColumn();



                }

            }
            catch (Exception exception)
            {
                if (exception.Source == "mscorlib" && exception.Message == "Yol geçerli bir biçimde değil.")
                {
                    MessageBox.Show("Lütfen geçerli bir resim yolu belirtiniz.");
                }


            }



            return ImageandFileRoad;



        }

        private List<string> ReadListViewFirstColumn()
        {
            List<string> firstColumn = new List<string>();
            List<string> SplittedFirstColumn = new List<string>();
            for (int i = 0; i < CombineImageListView.Items.Count; i++)
            {
                firstColumn.Add(CombineImageListView.Items[i].SubItems[0].ToString());
            }

            for (int i = 0; i < firstColumn.Count; i++)
            {
                string[] fileRoad = firstColumn[i].ToString().Split('{');
                string[] SplittedFileRoad = fileRoad[1].ToString().Split('}');
                SplittedFirstColumn.Add(SplittedFileRoad[0].ToString());
            }




            return SplittedFirstColumn;
        }
        private List<string> ReadListViewSecondColumn()
        {
            List<string> secondColumn = new List<string>();
            List<string> SplittedSecondColumn = new List<string>();

            for (int i = 0; i < CombineImageListView.Items.Count; i++)
            {
                secondColumn.Add(CombineImageListView.Items[i].SubItems[1].ToString());
            }
            for (int i = 0; i < secondColumn.Count; i++)
            {
                string[] fileRoad = secondColumn[i].ToString().Split('{');
                string[] SplittedFileRoad = fileRoad[1].ToString().Split('}');
                SplittedSecondColumn.Add(SplittedFileRoad[0].ToString());

            }

            return SplittedSecondColumn;
        }

        private void LoadListView()
        {
            CombineImageListView.View = View.Details;
            CombineImageListView.GridLines = true;
            CombineImageListView.FullRowSelect = true;
            CombineImageListView.Columns.Add("Dosya Yolu", 300);
            CombineImageListView.Columns.Add("Ürün Açıklaması", 250);


        }



        private void DeleteCombinListItem_Click(object sender, EventArgs e)
        {
            if (CombineImageListView.Items.Count != 0)
            {
                try
                {
                    while (CombineImageListView.SelectedItems.Count > 0)
                    {
                        CombineImageListView.Items.Remove(CombineImageListView.SelectedItems[0]);
                    }
                    lblCombinCountText.Text = CombineImageListView.Items.Count.ToString();

                }
                catch (Exception exception)
                {
                    if (exception.Source == "System.Windows.Forms" && exception.Message == "InvalidArgument='0' değeri 'index' için geçerli değil.\r\nParametre adı: index")

                    {
                        MessageBox.Show("Lütfen listeden silmek istediğiniz ürünü seçiniz!.");
                    }


                }

            }
        }

        private void CreateCombineForImageBtn_Click(object sender, EventArgs e)
        {
            CreateCombine();
        }

        private void DeleteCombineTextButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBoxx9.Text = "";
            textBoxx10.Text = "";
            textBoxx11.Text = "";
            textBoxx12.Text = "";
            textBoxx13.Text = "";
            textBoxx14.Text = "";
            textBoxx15.Text = "";
            textBoxx16.Text = "";
        }

        private void AutoCombineButton_Click(object sender, EventArgs e)
        {
            ClearListView();
            GetFileRoad();
            lblCombinCountText.Text = CombineImageListView.Items.Count.ToString();
            CreateCombine();


        }

        private void GetFileRoad()
        {

            List<string> randomCombine = new List<string>();
            List<int> randomCombineCounts = new List<int>();
            string fileRoad = @"C:\Users\Oğuzhan\Documents\AutoCombine";


            string[] dirs = Directory.GetFiles(fileRoad);
            Random rnd = new Random();
            string[] myRndomDirs = dirs.OrderBy(x => rnd.Next()).ToArray();

            if (dirs.Count() == 0)
            {
                MessageBox.Show("Belirtilen klasörde resim bulunamadı.");
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(0, dirs.Length);
                int randomInitalNumber = 0;

                //random.Next(0, dirs.Length - 1);

                int maxCombineCount = dirs.Count();


                for (int i = randomInitalNumber; i < maxCombineCount; i++)
                {
                    randomCombine.Add(dirs[i].ToString());

                }
                switch (SelectedCombineCount.SelectedIndex)
                {
                    //İkili Kombin
                    case 0:
                        List<string> twoAutoCombines = new List<string>();
                        Random randomTwo = new Random();
                        int randomTwoCombine = randomTwo.Next(2, randomCombine.Count);
                        int randomTwoCombine2 = randomTwo.Next(2, randomCombine.Count);

                        if (randomTwoCombine == randomTwoCombine2)
                        {
                            while (randomTwoCombine != randomTwoCombine2)
                            {
                                randomTwoCombine = randomTwo.Next(2, randomCombine.Count);
                                randomTwoCombine2 = randomTwo.Next(2, randomCombine.Count);
                            }
                        }
                        else
                        {
                            twoAutoCombines.Add(randomCombine[randomTwoCombine]);
                            twoAutoCombines.Add(randomCombine[randomTwoCombine2]);

                            if (SelectedCombineCount.SelectedItem == null)
                            {
                                MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                            }
                            else
                            {
                                foreach (var item in twoAutoCombines)
                                {
                                    string fileName = FileName.InfoForFileName(item.ToString());
                                    string[] words = fileName.Split('.');
                                    string[] items = { item.ToString(), words[0].ToString() };
                                    var row = new ListViewItem(items);

                                    CombineImageListView.Items.Add(row);


                                }
                            }
                        }

                        break;
                    //Üçlü Kombin
                    case 1:
                        List<string> treeAutoCombines = new List<string>();
                        int[] numbers3 = new int[3];
                        Random randomTree = new Random();
                        int count = 0;


                        while (count < 3)
                        {
                            int randomTreeCombine = randomTree.Next(2, randomCombine.Count);
                            if (numbers3.Contains(randomTreeCombine))
                                continue;
                            numbers3[count] = randomTreeCombine;
                            count++;
                        }


                        treeAutoCombines.Add(randomCombine[numbers3[0]]);
                        treeAutoCombines.Add(randomCombine[numbers3[1]]);
                        treeAutoCombines.Add(randomCombine[numbers3[2]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in treeAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;
                    //4 lü Kombin 
                    case 2:
                        List<string> fourAutoCombines = new List<string>();
                        int[] numbers4 = new int[4];
                        Random randomFour = new Random();
                        int count2 = 0;


                        while (count2 < 4)
                        {
                            int randomFourCombine = randomFour.Next(2, randomCombine.Count);
                            if (numbers4.Contains(randomFourCombine))
                                continue;
                            numbers4[count2] = randomFourCombine;
                            count2++;
                        }


                        fourAutoCombines.Add(randomCombine[numbers4[0]]);
                        fourAutoCombines.Add(randomCombine[numbers4[1]]);
                        fourAutoCombines.Add(randomCombine[numbers4[2]]);
                        fourAutoCombines.Add(randomCombine[numbers4[3]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in fourAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }
                        break;

                    case 3:
                        List<string> fiveAutoCombines = new List<string>();
                        int[] numbers5 = new int[5];
                        Random randomFive = new Random();
                        int count3 = 0;


                        while (count3 < 5)
                        {
                            int randomFiveCombine = randomFive.Next(2, randomCombine.Count);
                            if (numbers5.Contains(randomFiveCombine))
                                continue;
                            numbers5[count3] = randomFiveCombine;
                            count3++;
                        }


                        fiveAutoCombines.Add(randomCombine[numbers5[0]]);
                        fiveAutoCombines.Add(randomCombine[numbers5[1]]);
                        fiveAutoCombines.Add(randomCombine[numbers5[2]]);
                        fiveAutoCombines.Add(randomCombine[numbers5[3]]);
                        fiveAutoCombines.Add(randomCombine[numbers5[4]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in fiveAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }
                        break;

                    case 4:
                        List<string> sixAutoCombines = new List<string>();
                        int[] numbers6 = new int[6];
                        Random randomSix = new Random();
                        int count4 = 0;


                        while (count4 < 6)
                        {
                            int randomSixCombine = randomSix.Next(2, randomCombine.Count);
                            if (numbers6.Contains(randomSixCombine))
                                continue;
                            numbers6[count4] = randomSixCombine;
                            count4++;
                        }


                        sixAutoCombines.Add(randomCombine[numbers6[0]]);
                        sixAutoCombines.Add(randomCombine[numbers6[1]]);
                        sixAutoCombines.Add(randomCombine[numbers6[2]]);
                        sixAutoCombines.Add(randomCombine[numbers6[3]]);
                        sixAutoCombines.Add(randomCombine[numbers6[4]]);
                        sixAutoCombines.Add(randomCombine[numbers6[5]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in sixAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }
                        break;

                    case 5:
                        List<string> sevenAutoCombines = new List<string>();
                        int[] numbers7 = new int[7];
                        Random randomSeven = new Random();
                        int count5 = 0;


                        while (count5 < 7)
                        {
                            int randomSevenCombine = randomSeven.Next(2, randomCombine.Count);
                            if (numbers7.Contains(randomSevenCombine))
                                continue;
                            numbers7[count5] = randomSevenCombine;
                            count5++;
                        }


                        sevenAutoCombines.Add(randomCombine[numbers7[0]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[1]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[2]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[3]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[4]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[5]]);
                        sevenAutoCombines.Add(randomCombine[numbers7[6]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in sevenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }
                        break;

                    case 6:
                        List<string> eightAutoCombines = new List<string>();
                        int[] numbers8 = new int[8];
                        Random randomEight = new Random();
                        int count6 = 0;


                        while (count6 < 8)
                        {
                            int randomEightCombine = randomEight.Next(2, randomCombine.Count);
                            if (numbers8.Contains(randomEightCombine))
                                continue;
                            numbers8[count6] = randomEightCombine;
                            count6++;
                        }


                        eightAutoCombines.Add(randomCombine[numbers8[0]]);
                        eightAutoCombines.Add(randomCombine[numbers8[1]]);
                        eightAutoCombines.Add(randomCombine[numbers8[2]]);
                        eightAutoCombines.Add(randomCombine[numbers8[3]]);
                        eightAutoCombines.Add(randomCombine[numbers8[4]]);
                        eightAutoCombines.Add(randomCombine[numbers8[5]]);
                        eightAutoCombines.Add(randomCombine[numbers8[6]]);
                        eightAutoCombines.Add(randomCombine[numbers8[7]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in eightAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;

                    case 7:
                        List<string> nineAutoCombines = new List<string>();
                        int[] numbers9 = new int[9];
                        Random randomNine = new Random();
                        int count7 = 0;


                        while (count7 < 9)
                        {
                            int randomNineCombine = randomNine.Next(2, randomCombine.Count);
                            if (numbers9.Contains(randomNineCombine))
                                continue;
                            numbers9[count7] = randomNineCombine;
                            count7++;
                        }


                        nineAutoCombines.Add(randomCombine[numbers9[0]]);
                        nineAutoCombines.Add(randomCombine[numbers9[1]]);
                        nineAutoCombines.Add(randomCombine[numbers9[2]]);
                        nineAutoCombines.Add(randomCombine[numbers9[3]]);
                        nineAutoCombines.Add(randomCombine[numbers9[4]]);
                        nineAutoCombines.Add(randomCombine[numbers9[5]]);
                        nineAutoCombines.Add(randomCombine[numbers9[6]]);
                        nineAutoCombines.Add(randomCombine[numbers9[7]]);
                        nineAutoCombines.Add(randomCombine[numbers9[8]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in nineAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }


                        break;

                    case 8:
                        List<string> tenAutoCombines = new List<string>();
                        int[] numbers10 = new int[10];
                        Random randomTen = new Random();
                        int count8 = 0;


                        while (count8 < 10)
                        {
                            int randomTenCombine = randomTen.Next(2, randomCombine.Count);
                            if (numbers10.Contains(randomTenCombine))
                                continue;
                            numbers10[count8] = randomTenCombine;
                            count8++;
                        }


                        tenAutoCombines.Add(randomCombine[numbers10[0]]);
                        tenAutoCombines.Add(randomCombine[numbers10[1]]);
                        tenAutoCombines.Add(randomCombine[numbers10[2]]);
                        tenAutoCombines.Add(randomCombine[numbers10[3]]);
                        tenAutoCombines.Add(randomCombine[numbers10[4]]);
                        tenAutoCombines.Add(randomCombine[numbers10[5]]);
                        tenAutoCombines.Add(randomCombine[numbers10[6]]);
                        tenAutoCombines.Add(randomCombine[numbers10[7]]);
                        tenAutoCombines.Add(randomCombine[numbers10[8]]);
                        tenAutoCombines.Add(randomCombine[numbers10[9]]);

                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in tenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;

                    case 9:
                        List<string> elevenAutoCombines = new List<string>();
                        int[] numbers11 = new int[11];
                        Random randomEleven = new Random();
                        int count9 = 0;


                        while (count9 < 11)
                        {
                            int randomElevenCombine = randomEleven.Next(2, randomCombine.Count);
                            if (numbers11.Contains(randomElevenCombine))
                                continue;
                            numbers11[count9] = randomElevenCombine;
                            count9++;
                        }


                        elevenAutoCombines.Add(randomCombine[numbers11[0]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[1]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[2]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[3]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[4]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[5]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[6]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[7]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[8]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[9]]);
                        elevenAutoCombines.Add(randomCombine[numbers11[10]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in elevenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;

                    case 10:

                        List<string> twelveAutoCombines = new List<string>();
                        int[] numbers12 = new int[12];
                        Random randomTwelve = new Random();
                        int count10 = 0;


                        while (count10 < 12)
                        {
                            int randomTwelveCombine = randomTwelve.Next(2, randomCombine.Count);
                            if (numbers12.Contains(randomTwelveCombine))
                                continue;
                            numbers12[count10] = randomTwelveCombine;
                            count10++;
                        }


                        twelveAutoCombines.Add(randomCombine[numbers12[0]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[1]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[2]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[3]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[4]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[5]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[6]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[7]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[8]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[9]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[10]]);
                        twelveAutoCombines.Add(randomCombine[numbers12[11]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in twelveAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;

                    case 11:

                        List<string> thirteenAutoCombines = new List<string>();
                        int[] numbers13 = new int[13];
                        Random randomThirteen = new Random();
                        int count11 = 0;


                        while (count11 < 13)
                        {
                            int randomThirteenCombine = randomThirteen.Next(2, randomCombine.Count);
                            if (numbers13.Contains(randomThirteenCombine))
                                continue;
                            numbers13[count11] = randomThirteenCombine;
                            count11++;
                        }


                        thirteenAutoCombines.Add(randomCombine[numbers13[0]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[1]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[2]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[3]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[4]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[5]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[6]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[7]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[8]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[9]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[10]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[11]]);
                        thirteenAutoCombines.Add(randomCombine[numbers13[12]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in thirteenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }


                        break;

                    case 12:
                        List<string> fourteenAutoCombines = new List<string>();
                        int[] numbers14 = new int[14];
                        Random randomFourteen = new Random();
                        int count12 = 0;


                        while (count12 < 14)
                        {
                            int randomFourteenCombine = randomFourteen.Next(2, randomCombine.Count);
                            if (numbers14.Contains(randomFourteenCombine))
                                continue;
                            numbers14[count12] = randomFourteenCombine;
                            count12++;
                        }


                        fourteenAutoCombines.Add(randomCombine[numbers14[0]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[1]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[2]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[3]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[4]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[5]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[6]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[7]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[8]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[9]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[10]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[11]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[12]]);
                        fourteenAutoCombines.Add(randomCombine[numbers14[13]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in fourteenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }


                        break;

                    case 13:

                        List<string> fifteenAutoCombines = new List<string>();
                        int[] numbers15 = new int[15];
                        Random randomFifteen = new Random();
                        int count13 = 0;


                        while (count13 < 15)
                        {
                            int randomFifteenCombine = randomFifteen.Next(2, randomCombine.Count);
                            if (numbers15.Contains(randomFifteenCombine))
                                continue;
                            numbers15[count13] = randomFifteenCombine;
                            count13++;
                        }


                        fifteenAutoCombines.Add(randomCombine[numbers15[0]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[1]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[2]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[3]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[4]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[5]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[6]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[7]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[8]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[9]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[10]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[11]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[12]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[13]]);
                        fifteenAutoCombines.Add(randomCombine[numbers15[14]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in fifteenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;

                    case 14:
                        List<string> sixteenAutoCombines = new List<string>();
                        int[] numbers16 = new int[16];
                        Random randomSixteen = new Random();
                        int count14 = 0;


                        while (count14 < 16)
                        {
                            int randomSixteenCombine = randomSixteen.Next(2, randomCombine.Count);
                            if (numbers16.Contains(randomSixteenCombine))
                                continue;
                            numbers16[count14] = randomSixteenCombine;
                            count14++;
                        }


                        sixteenAutoCombines.Add(randomCombine[numbers16[0]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[1]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[2]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[3]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[4]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[5]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[6]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[7]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[8]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[9]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[10]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[11]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[12]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[13]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[14]]);
                        sixteenAutoCombines.Add(randomCombine[numbers16[15]]);


                        if (SelectedCombineCount.SelectedItem == null)
                        {
                            MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                        }
                        else
                        {
                            foreach (var item in sixteenAutoCombines)
                            {
                                string fileName = FileName.InfoForFileName(item.ToString());
                                string[] words = fileName.Split('.');
                                string[] items = { item.ToString(), words[0].ToString() };
                                var row = new ListViewItem(items);

                                CombineImageListView.Items.Add(row);


                            }
                        }

                        break;
                    default:
                        break;
                }





                //if (SelectedCombineCount.SelectedItem == null)
                //{
                //    MessageBox.Show("Auto kombin yapmak için lütfen sayı belirtiniz.");
                //}
                //else
                //{
                //    foreach (var item in randomCombine)
                //    {
                //        string fileName = FileName.InfoForFileName(item.ToString());
                //        string[] words = fileName.Split('.');
                //        string[] items = { item.ToString(), words[0].ToString() };
                //        var row = new ListViewItem(items);

                //        CombineImageListView.Items.Add(row);


                //    }
                //}


            }





        }

        private void CreateCombine()
        {
            int ImageCount = Convert.ToInt32(lblCombinCountText.Text);
            switch (ImageCount)
            {
                case 1:
                    MessageBox.Show("Bir resim için kombin yapılamaz.");
                    break;
                case 2:
                    var fileRoads = ReadListViewFirstColumn();
                    var productNames = ReadListViewSecondColumn();

                    if (fileRoads.Count != 0)
                    {
                        var result = CombineForImage.combineFor2Images(fileRoads[0], fileRoads[1]);

                        if (productNames.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNames[0].ToString();
                                textBox2.Text = productNames[1].ToString();
                                MessageBox.Show("2'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }

                    break;
                case 3:
                    var fileRoadsfor3 = ReadListViewFirstColumn();
                    var productNamesfor3 = ReadListViewSecondColumn();
                    if (fileRoadsfor3.Count != 0)
                    {
                        var result = CombineForImage.combineFor3Images(fileRoadsfor3[0], fileRoadsfor3[1], fileRoadsfor3[2]);

                        if (productNamesfor3.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor3[0].ToString();
                                textBox2.Text = productNamesfor3[1].ToString();
                                textBox3.Text = productNamesfor3[2].ToString();
                                MessageBox.Show("3'lü Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 4:
                    var fileRoadsfor4 = ReadListViewFirstColumn();
                    var productNamesfor4 = ReadListViewSecondColumn();
                    if (fileRoadsfor4.Count != 0)
                    {
                        var result = CombineForImage.combineFor4Images(fileRoadsfor4[0], fileRoadsfor4[1], fileRoadsfor4[2], fileRoadsfor4[3]);

                        if (productNamesfor4.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor4[0].ToString();
                                textBox2.Text = productNamesfor4[1].ToString();
                                textBox3.Text = productNamesfor4[2].ToString();
                                textBox4.Text = productNamesfor4[3].ToString();
                                MessageBox.Show("4'lü Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 5:
                    var fileRoadsfor5 = ReadListViewFirstColumn();
                    var productNamesfor5 = ReadListViewSecondColumn();
                    if (fileRoadsfor5.Count != 0)
                    {
                        var result = CombineForImage.combineFor5Images(fileRoadsfor5);

                        if (productNamesfor5.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor5[0].ToString();
                                textBox2.Text = productNamesfor5[1].ToString();
                                textBox3.Text = productNamesfor5[2].ToString();
                                textBox4.Text = productNamesfor5[3].ToString();
                                textBox5.Text = productNamesfor5[4].ToString();
                                MessageBox.Show("5'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 6:
                    var fileRoadsfor6 = ReadListViewFirstColumn();
                    var productNamesfor6 = ReadListViewSecondColumn();
                    if (fileRoadsfor6.Count != 0)
                    {
                        var result = CombineForImage.combineFor6Images(fileRoadsfor6);

                        if (productNamesfor6.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor6[0].ToString();
                                textBox2.Text = productNamesfor6[1].ToString();
                                textBox3.Text = productNamesfor6[2].ToString();
                                textBox4.Text = productNamesfor6[3].ToString();
                                textBox5.Text = productNamesfor6[4].ToString();
                                textBox6.Text = productNamesfor6[5].ToString();
                                MessageBox.Show("6'lı Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 7:
                    var fileRoadsfor7 = ReadListViewFirstColumn();
                    var productNamesfor7 = ReadListViewSecondColumn();
                    if (fileRoadsfor7.Count != 0)
                    {
                        var result = CombineForImage.combineFor7Images(fileRoadsfor7);

                        if (productNamesfor7.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor7[0].ToString();
                                textBox2.Text = productNamesfor7[1].ToString();
                                textBox3.Text = productNamesfor7[2].ToString();
                                textBox4.Text = productNamesfor7[3].ToString();
                                textBox5.Text = productNamesfor7[4].ToString();
                                textBox6.Text = productNamesfor7[5].ToString();
                                textBox7.Text = productNamesfor7[6].ToString();
                                MessageBox.Show("7'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 8:
                    var fileRoadsfor8 = ReadListViewFirstColumn();
                    var productNamesfor8 = ReadListViewSecondColumn();
                    if (fileRoadsfor8.Count != 0)
                    {
                        var result = CombineForImage.combineFor8Images(fileRoadsfor8);

                        if (productNamesfor8.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor8[0].ToString();
                                textBox2.Text = productNamesfor8[1].ToString();
                                textBox3.Text = productNamesfor8[2].ToString();
                                textBox4.Text = productNamesfor8[3].ToString();
                                textBox5.Text = productNamesfor8[4].ToString();
                                textBox6.Text = productNamesfor8[5].ToString();
                                textBox7.Text = productNamesfor8[6].ToString();
                                textBox8.Text = productNamesfor8[7].ToString();
                                MessageBox.Show("8'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 9:
                    var fileRoadsfor9 = ReadListViewFirstColumn();
                    var productNamesfor9 = ReadListViewSecondColumn();
                    if (fileRoadsfor9.Count != 0)
                    {
                        var result = CombineForImage.combineFor9Images(fileRoadsfor9);

                        if (productNamesfor9.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor9[0].ToString();
                                textBox2.Text = productNamesfor9[1].ToString();
                                textBox3.Text = productNamesfor9[2].ToString();
                                textBox4.Text = productNamesfor9[3].ToString();
                                textBox5.Text = productNamesfor9[4].ToString();
                                textBox6.Text = productNamesfor9[5].ToString();
                                textBox7.Text = productNamesfor9[6].ToString();
                                textBox8.Text = productNamesfor9[7].ToString();
                                textBoxx9.Text = productNamesfor9[8].ToString();

                                MessageBox.Show("9'lu Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 10:
                    var fileRoadsfor10 = ReadListViewFirstColumn();
                    var productNamesfor10 = ReadListViewSecondColumn();
                    if (fileRoadsfor10.Count != 0)
                    {
                        var result = CombineForImage.combineFor10Images(fileRoadsfor10);

                        if (productNamesfor10.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor10[0].ToString();
                                textBox2.Text = productNamesfor10[1].ToString();
                                textBox3.Text = productNamesfor10[2].ToString();
                                textBox4.Text = productNamesfor10[3].ToString();
                                textBox5.Text = productNamesfor10[4].ToString();
                                textBox6.Text = productNamesfor10[5].ToString();
                                textBox7.Text = productNamesfor10[6].ToString();
                                textBox8.Text = productNamesfor10[7].ToString();
                                textBoxx9.Text = productNamesfor10[8].ToString();
                                textBoxx10.Text = productNamesfor10[9].ToString();

                                MessageBox.Show("10'lu Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 11:
                    var fileRoadsfor11 = ReadListViewFirstColumn();
                    var productNamesfor11 = ReadListViewSecondColumn();
                    if (fileRoadsfor11.Count != 0)
                    {
                        var result = CombineForImage.combineFor11Images(fileRoadsfor11);

                        if (productNamesfor11.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor11[0].ToString();
                                textBox2.Text = productNamesfor11[1].ToString();
                                textBox3.Text = productNamesfor11[2].ToString();
                                textBox4.Text = productNamesfor11[3].ToString();
                                textBox5.Text = productNamesfor11[4].ToString();
                                textBox6.Text = productNamesfor11[5].ToString();
                                textBox7.Text = productNamesfor11[6].ToString();
                                textBox8.Text = productNamesfor11[7].ToString();
                                textBoxx9.Text = productNamesfor11[8].ToString();
                                textBoxx10.Text = productNamesfor11[9].ToString();
                                textBoxx11.Text = productNamesfor11[10].ToString();

                                MessageBox.Show("11'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 12:
                    var fileRoadsfor12 = ReadListViewFirstColumn();
                    var productNamesfor12 = ReadListViewSecondColumn();
                    if (fileRoadsfor12.Count != 0)
                    {
                        var result = CombineForImage.combineFor12Images(fileRoadsfor12);

                        if (productNamesfor12.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor12[0].ToString();
                                textBox2.Text = productNamesfor12[1].ToString();
                                textBox3.Text = productNamesfor12[2].ToString();
                                textBox4.Text = productNamesfor12[3].ToString();
                                textBox5.Text = productNamesfor12[4].ToString();
                                textBox6.Text = productNamesfor12[5].ToString();
                                textBox7.Text = productNamesfor12[6].ToString();
                                textBox8.Text = productNamesfor12[7].ToString();
                                textBoxx9.Text = productNamesfor12[8].ToString();
                                textBoxx10.Text = productNamesfor12[9].ToString();
                                textBoxx11.Text = productNamesfor12[10].ToString();
                                textBoxx12.Text = productNamesfor12[11].ToString();

                                MessageBox.Show("12'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;

                case 13:
                    var fileRoadsfor13 = ReadListViewFirstColumn();
                    var productNamesfor13 = ReadListViewSecondColumn();
                    if (fileRoadsfor13.Count != 0)
                    {
                        var result = CombineForImage.combineFor13Images(fileRoadsfor13);

                        if (productNamesfor13.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor13[0].ToString();
                                textBox2.Text = productNamesfor13[1].ToString();
                                textBox3.Text = productNamesfor13[2].ToString();
                                textBox4.Text = productNamesfor13[3].ToString();
                                textBox5.Text = productNamesfor13[4].ToString();
                                textBox6.Text = productNamesfor13[5].ToString();
                                textBox7.Text = productNamesfor13[6].ToString();
                                textBox8.Text = productNamesfor13[7].ToString();
                                textBoxx9.Text = productNamesfor13[8].ToString();
                                textBoxx10.Text = productNamesfor13[9].ToString();
                                textBoxx11.Text = productNamesfor13[10].ToString();
                                textBoxx12.Text = productNamesfor13[11].ToString();
                                textBoxx13.Text = productNamesfor13[12].ToString();

                                MessageBox.Show("13'lü Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 14:
                    var fileRoadsfor14 = ReadListViewFirstColumn();
                    var productNamesfor14 = ReadListViewSecondColumn();
                    if (fileRoadsfor14.Count != 0)
                    {
                        var result = CombineForImage.combineFor14Images(fileRoadsfor14);

                        if (productNamesfor14.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor14[0].ToString();
                                textBox2.Text = productNamesfor14[1].ToString();
                                textBox3.Text = productNamesfor14[2].ToString();
                                textBox4.Text = productNamesfor14[3].ToString();
                                textBox5.Text = productNamesfor14[4].ToString();
                                textBox6.Text = productNamesfor14[5].ToString();
                                textBox7.Text = productNamesfor14[6].ToString();
                                textBox8.Text = productNamesfor14[7].ToString();
                                textBoxx9.Text = productNamesfor14[8].ToString();
                                textBoxx10.Text = productNamesfor14[9].ToString();
                                textBoxx11.Text = productNamesfor14[10].ToString();
                                textBoxx12.Text = productNamesfor14[11].ToString();
                                textBoxx13.Text = productNamesfor14[12].ToString();
                                textBoxx14.Text = productNamesfor14[13].ToString();

                                MessageBox.Show("14'lü Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 15:
                    var fileRoadsfor15 = ReadListViewFirstColumn();
                    var productNamesfor15 = ReadListViewSecondColumn();
                    if (fileRoadsfor15.Count != 0)
                    {
                        var result = CombineForImage.combineFor15Images(fileRoadsfor15);

                        if (productNamesfor15.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor15[0].ToString();
                                textBox2.Text = productNamesfor15[1].ToString();
                                textBox3.Text = productNamesfor15[2].ToString();
                                textBox4.Text = productNamesfor15[3].ToString();
                                textBox5.Text = productNamesfor15[4].ToString();
                                textBox6.Text = productNamesfor15[5].ToString();
                                textBox7.Text = productNamesfor15[6].ToString();
                                textBox8.Text = productNamesfor15[7].ToString();
                                textBoxx9.Text = productNamesfor15[8].ToString();
                                textBoxx10.Text = productNamesfor15[9].ToString();
                                textBoxx11.Text = productNamesfor15[10].ToString();
                                textBoxx12.Text = productNamesfor15[11].ToString();
                                textBoxx13.Text = productNamesfor15[12].ToString();
                                textBoxx14.Text = productNamesfor15[13].ToString();
                                textBoxx15.Text = productNamesfor15[14].ToString();

                                MessageBox.Show("15'li Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }
                    break;
                case 16:
                    var fileRoadsfor16 = ReadListViewFirstColumn();
                    var productNamesfor16 = ReadListViewSecondColumn();
                    if (fileRoadsfor16.Count != 0)
                    {
                        var result = CombineForImage.combineFor16Images(fileRoadsfor16);

                        if (productNamesfor16.Count != 0)
                        {


                            if (result == true)
                            {
                                textBox1.Text = productNamesfor16[0].ToString();
                                textBox2.Text = productNamesfor16[1].ToString();
                                textBox3.Text = productNamesfor16[2].ToString();
                                textBox4.Text = productNamesfor16[3].ToString();
                                textBox5.Text = productNamesfor16[4].ToString();
                                textBox6.Text = productNamesfor16[5].ToString();
                                textBox7.Text = productNamesfor16[6].ToString();
                                textBox8.Text = productNamesfor16[7].ToString();
                                textBoxx9.Text = productNamesfor16[8].ToString();
                                textBoxx10.Text = productNamesfor16[9].ToString();
                                textBoxx11.Text = productNamesfor16[10].ToString();
                                textBoxx12.Text = productNamesfor16[11].ToString();
                                textBoxx13.Text = productNamesfor16[12].ToString();
                                textBoxx14.Text = productNamesfor16[13].ToString();
                                textBoxx15.Text = productNamesfor16[14].ToString();
                                textBoxx16.Text = productNamesfor16[15].ToString();

                                MessageBox.Show("16'lı Kombin Oluşturuldu!.");
                            }
                            else
                            {

                                MessageBox.Show("Kombin Oluşturulmadı!.");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kombin yapılacak resim bulunamadı.");
                    }

                    break;
                default:
                    if (Convert.ToInt32(lblCombinCountText.Text) == 0)
                    {
                        MessageBox.Show("Resim eklemeden kombin yapılamaz.");
                    }
                    else
                    {
                        MessageBox.Show("Seçilen resim sayısı kombin aralığının dışında yer almaktadır.");
                    }

                    break;
            }
        }

        private void ClearListView()
        {
            CombineImageListView.Items.Clear();
        }

        private void ClearListViewButton_Click(object sender, EventArgs e)
        {
            ClearListView();
            lblCombinCountText.Text = "0";
        }

        private void LoadAutoComboBoxItems()
        {
            SelectedCombineCount.Items.Add("Kombin sayısı - 2 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 3 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 4 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 5 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 6 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 7 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 8 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 9 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 10 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 11 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 12 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 13 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 14 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 15 ");
            SelectedCombineCount.Items.Add("Kombin sayısı - 16 ");

        }
    }
}
