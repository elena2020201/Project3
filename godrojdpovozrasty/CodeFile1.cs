using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
class DialogDemo
{
    static void Main()
    {
        string name;
        name = Interaction.InputBox(
            "Укажите Ваше имя", "Давайте познакомимся...");
        string txt;
        txt = ("Очень приятно," + name + " !");
        MessageBox.Show(txt, "Знакомство состоялось");
        string res;
        int year = 2020, born, age;
        res = Interaction.InputBox("Сколько Вам лет?", "Возраст");
        age = Int32.Parse(res);
        born = year - age;
        res = "" + name + ", Вы родились в " + born + " году";
        MessageBox.Show(res, "Год рождения");
    }
}