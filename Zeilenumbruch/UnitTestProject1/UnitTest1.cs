using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeilenumbruch;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Brecher brecher;
        Form1 testForm;
        public UnitTest1()
        {                       
            testForm = new Form1();
            brecher = new Brecher(testForm.TextBox1.Text);
        }
        [TestMethod]
        public void BrecherTextIsNotEmpty()
        {
            Assert.AreNotEqual(String.Empty, brecher.Text);
        }
        [TestMethod]
        public void VorherTextIsNotEmpty() 
        {
            Assert.AreNotEqual(String.Empty, testForm.TextBox1.Text);
        }
        [TestMethod]
        public void BrecherReceivesTextFromVorher() 
        {
            Assert.AreEqual(brecher.Text, testForm.TextBox1.Text);
        }      
        [TestMethod]
        public void VerifyThatBrecherConstructorWillNotWorkWithNull() 
        {
            Brecher bb = new Brecher(null);
            Assert.AreEqual(false, bb.IsNotNull);
        }
        [TestMethod]
        public void LaengeIsConvertableToInteger()
        {
            Assert.AreEqual(testForm.ParsableToInteger(testForm.TextBox3.Text), true);
        }

        [TestMethod]
        public void TextBoxesAreNotEmpty() 
        {
            bool test1 = testForm.CheckStringForEmpty(testForm.TextBox1.Text);
            bool test2 = testForm.CheckStringForEmpty(testForm.TextBox3.Text);

            if (test1 == false && test2 == false)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void NachherisEmptyByDefault()
        {
            Assert.AreEqual(String.Empty, testForm.TextBox2.Text);
        }
        [TestMethod]
        public void NachherIsUnequalToVorher()
        {
            testForm.TextBox2.Text = brecher.Umbrechen(6);
            Assert.AreNotEqual(testForm.TextBox2.Text, testForm.TextBox1.Text);
        }
        [TestMethod]
        public void NachherContainsABreak()
        {
            testForm.TextBox2.Text = brecher.Umbrechen(5);
            String text = testForm.TextBox2.Text;

            if (text.Contains("\n") == true)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail("Es wurde kein Break in Nachher gefunden!");
            }
        }
        [TestMethod]
        public void LaengeIsNotEqualToZero()
        {
            Assert.IsTrue(testForm.IntegerIsNotZero(Convert.ToInt32(testForm.TextBox3.Text)));
        }
        [TestMethod]
        public void LinesInNachherAreNotLongerThanLaenge()
        {
            int laenge = 6;
            testForm.TextBox2.Text = brecher.Umbrechen(laenge);
            String text = testForm.TextBox2.Text;
            int j = 0;

            foreach (Char ch in text)
            {
                j++;
                if (ch == '\n')
                {
                    j--;
                    if (j > laenge)
                    {
                        Assert.Fail("Die Zeile ist zu lang!");
                        return;
                    }
                    else
                    {
                        Assert.IsTrue(true);
                        return;
                    }

                }               
            }
        }
        [TestMethod]
        public void BrecherDoesNotCutWords()
        {
            int laenge = 12;
            testForm.TextBox2.Text = brecher.Umbrechen(laenge);
            String text = testForm.TextBox2.Text;
            int i;

            for (i = 0; i == text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    if (text[(i - 1)] != ' ' && text[(i + 1)] != ' ')
                    {
                        Assert.Fail("Ein Wort wurde durch den Brecher zerschnitten!");
                        return;
                    }                  
                }                
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BrecherHandlesWordsWhichAreLongerThanLaengeCorrectly()
        {
            int laenge = 12;            
            testForm.TextBox1.Text = "Rindfleischetikettierungsüberwachungsaufgabenübertragungsgesetz"; //Quelle Internet
            String text1 = testForm.TextBox1.Text;
            Brecher bb = new Brecher(text1);
            testForm.TextBox2.Text = bb.Umbrechen(laenge);
            String text2 = testForm.TextBox2.Text;

            if (!text1.Contains(" "))
            {
                if (text1.Length > laenge)
                {
                    if (text2.Contains("\n"))
                    {
                        Assert.Fail("Das Wort wurde abgeschnitten!");
                        return;
                    }
                    Assert.IsTrue(true);
                }
            }
        }       
    }
}
