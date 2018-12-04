using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private static RadioButton rad1;
        private static RadioButton rad2;
        private static RadioButton rad3;
        private static TextBlock y2;

        public MainWindow()
        {
            InitializeComponent();
            rad1 = a2;
            rad2 = b2;
            rad3 = c2;
        }

        private void SP_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "5 351 935  человек";
            pl.Text = "1403 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−35,9°C";
            tmax.Text = "37,1°C";
            name.Text = "Санкт-Петербург";
            U("Санкт-Петербурга");

        }
        private void YaV_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "608 722 человека";
            pl.Text = "205,80 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−46,0 °C";
            tmax.Text = "38,0 °C";
            name.Text = "Ярославль";

            U("Ярославля");

        }
        private void MoVa_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "12 506 468 человека";
            pl.Text = "2561,5 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−42,1 °C";
            tmax.Text = "38,2 °C";
            name.Text = "Москва";

            U("Москвы");

        }
        private void TL_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "482 873 человека";
            pl.Text = "145,8 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−36,1 °C";
            tmax.Text = "39,2 °C";
            name.Text = "Тула";

            U("Тулы");

        }
        private void NN_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 259 013 человека";
            pl.Text = "410,68 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−41,4 °C";
            tmax.Text = "38,2 °C";
            name.Text = "Нижний Новгород";

            U("Нижнего Новгорода");

        }
        private void RZh_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "538 962 человека";
            pl.Text = "224,163 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−40,9 °C";
            tmax.Text = "39,5 °C";
            name.Text = "Рязань";

            U("Рязани");

        }
        private void LP_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "509 735 человека";
            pl.Text = "330,15 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−12,9 °C";
            tmax.Text = "24,8 °C";
            name.Text = "Липецк";

            U("Липецка");

        }
        private void VoRo_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 058 547 человека";
            pl.Text = "596,51 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−36,5 °C";
            tmax.Text = "40,5 °C";
            name.Text = "Воронеж";

            U("Воронежа");

        }
        private void Penza_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "523 553 человека";
            pl.Text = "288,5 км²";
            chp.Text = "UTC+3";
            tmin.Text = "-40,5 °C";
            tmax.Text = "40,4 °C";
            name.Text = "Пенза";

            U("Пензы");

        }
        private void UZh_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "648 213 человека";
            pl.Text = "315,15 км²";
            chp.Text = "UTC+4";
            tmin.Text = "−47,5 °C";
            tmax.Text = "37,0 °C";
            name.Text = "Ижевск";

            U("Ижевска");
        }
        private void Perm_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 051 583 человека";
            pl.Text = "801,44 км²";
            chp.Text = "UTC+5";
            tmin.Text = "−47,1 °C";
            tmax.Text = "37,2 °C";
            name.Text = "Пермь";

            U("Перми");

        }
        private void Ulaynovsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "626 540 человека";
            pl.Text = "622,5 км²";
            chp.Text = "UTC+4";
            tmin.Text = "−40,0 °C";
            tmax.Text = "39,3 °C";
            name.Text = "Ульяновск";

            U("Ульяновска");

        }
        private void Naberezhnue_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "529 797 человека";
            pl.Text = "161 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−18,0 °C";
            tmax.Text = "26,0 °C";
            name.Text = "Набережные Челны";

            U("Набережных Челнов");

        }
        private void Tolyatti_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "707 408 человека";
            pl.Text = "314,78  км²";
            chp.Text = "UTC+4";
            tmin.Text = "−43 °C";
            tmax.Text = "40,5 °C";
            name.Text = "Тольятти";

            U("Тольятти");

        }
        private void Samara_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 163 399 человека";
            pl.Text = "541,4  км²";
            chp.Text = "UTC+4";
            tmin.Text = "−43 °C";
            tmax.Text = "39,9 °C";
            name.Text = "Самара";

            U("Самары");

        }
        private void Ufa_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 120 547 человека";
            pl.Text = "707,93  км²";
            chp.Text = "UTC+5";
            tmin.Text = "−48,5 °C";
            tmax.Text = "38,6 °C";
            name.Text = "Уфа";


            U("Уфы");
        }
        private void Ecaterinburg_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 468 833 человека";
            pl.Text = "468 км²";
            chp.Text = "UTC+5";
            tmin.Text = "−46,7 °C";
            tmax.Text = "38,8 °C";
            name.Text = "Екатеринбург";

            U("Екатеринбурга");//

        }
        private void Saratov_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "844 858 человека";
            pl.Text = "394 км²";
            chp.Text = "UTC+4";
            tmin.Text = "−37,7 °C";
            tmax.Text = "40,9 °C";
            name.Text = "Саратов";

            U("Саратова");

        }
        private void Kazan_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 243 500 человека";
            pl.Text = "425,3 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−46,8 °C";
            tmax.Text = "39,0 °C";
            name.Text = "Казань";

            U("Казани");

        }
        private void Tumen_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "768 358 человека";
            pl.Text = "698 км²";
            chp.Text = "UTC+5";
            tmin.Text = "−49,2 °C";
            tmax.Text = "37,5 °C";
            name.Text = "Тюмень";

            U("Тюмени");

        }
        private void Chelaybinsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 202 371 человека";
            pl.Text = "500,91 км²";
            chp.Text = "UTC+5";
            tmin.Text = "−48,7 °C";
            tmax.Text = "39,2 °C";
            name.Text = "Челябинск";

            U("Челябинска");//

        }
        private void Orenburg_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "564 443 человека";
            pl.Text = "874 км²";
            chp.Text = "UTC+5";
            tmin.Text = "−43,2 °C";
            tmax.Text = "41,6 °C";
            name.Text = "Оренург";

            U("Оренбурга");

        }
        private void Volgograd_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 013 533 человека";
            pl.Text = "859,353 км²";
            chp.Text = "UTC+4";
            tmin.Text = "-33,0 °C";
            tmax.Text = "42,6 °C";
            name.Text = "Волгоград";

            U("Волгограда");

        }
        private void R_N_D_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 130 305 человека";
            pl.Text = "348,5 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−31,9 °C";
            tmax.Text = "40,1 °C";
            name.Text = "Ростов-на-Дону";

            U("Ростова-на-Дону");

        }
        private void Krasnodar_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "899 541 человека";
            pl.Text = "339,31 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−32,9 °C";
            tmax.Text = "40,7 °C";
            name.Text = "Краснодар";

            U("Краснодара");

        }
        private void Astrahan_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "533 925 человека";
            pl.Text = "208,70 км²";
            chp.Text = "UTC+4";
            tmin.Text = "−33,6 °C";
            tmax.Text = "41,0 °C";
            name.Text = "Астрахань";

            U("Астрахани");

        }
        private void Sevastopl_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "436 670 человека";
            pl.Text = "1079,6 км²";
            chp.Text = "UTC+3";
            tmin.Text = "−22,0 °C";
            tmax.Text = "38,3 °C";
            name.Text = "Севастополь";

            U("Севастополя");//

        }
        private void Omsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 172 070 человека";
            pl.Text = "566,9 км²";
            chp.Text = "UTC+6";
            tmin.Text = "−45,5 °C";
            tmax.Text = "40,4 °C";
            name.Text = "Омск";

            U("Омска");

        }
        private void Novosib_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 612 833 человека";
            pl.Text = "505,62 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−51,1 °C";
            tmax.Text = "38,3 °C";
            name.Text = "Новосибирск";

            U("Новосибирска");

        }
        private void Tomsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "574 002 человека";
            pl.Text = "294,6 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−55 °C";
            tmax.Text = "35,9 °C";
            name.Text = "Томск";

            U("Томска");

        }
        private void Kemerovo_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "558 973 человека";
            pl.Text = "294,8 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−48,4 °C";
            tmax.Text = "38,0 °C";
            name.Text = "Кемерово";

            U("Кемерова");

        }
        private void Barnaul_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "632 372 человека";
            pl.Text = "322,01 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−51,5 °C";
            tmax.Text = "38,3 °C";
            name.Text = "Барнаул";

            U("Барнаула");

        }
        private void Novocuzn_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "552 445 человека";
            pl.Text = "424,27 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−47,7 °C";
            tmax.Text = "36,0 °C";
            name.Text = "Новокузнецк";

            U("Новокузнецка");

        }
        private void Krasnoayrsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "1 090 811 человека";
            pl.Text = "353,9 км²";
            chp.Text = "UTC+7";
            tmin.Text = "−52,8 °C";
            tmax.Text = "36,4 °C";
            name.Text = "Красноярск";

            U("Красноярска");

        }
        private void Ircutsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "623 869 человека";
            pl.Text = "277 км²";
            chp.Text = "UTC+8";
            tmin.Text = "−49,7 °C";
            tmax.Text = "37,2 °C";
            name.Text = "Иркутск";

            U("Иркутска");

        }
        private void Habarovsk_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "618 150 человека";
            pl.Text = "383 км²";
            chp.Text = "UTC+10";
            tmin.Text = "−41,1 °C";
            tmax.Text = "36,7 °C";
            name.Text = "Хабаровск";

            U("Хабаровска");

        }
        private void Vladivostok_Click(object sender, RoutedEventArgs e)
        {
            kn.Text = "604 901 человека";
            pl.Text = "331,16 км²";
            chp.Text = "UTC+10";
            tmin.Text = "−31,4 °C";
            tmax.Text = "33,6 °C";
            name.Text = "Владивосток";

            U("Владивостока");

        }

        private void U(string name)
        {
            if ((first.Text != "???") && (second.Text != "???"))
            {
                string one = second.Text;
                string two = name;
                first.Text = one;
                second.Text = two;
                OtUDo(one, two);
            }
            if ((first.Text != "???") && (second.Text == "???"))
            {
                string one = first.Text;
                string two = name;
                first.Text = one;
                second.Text = two;
                OtUDo(one, two);
            }
            if ((first.Text == "???") && (second.Text == "???"))
            {
                string one = name;
                first.Text = one;
            }
        }
        private void OtUDo(string first, string second)
        {
            switch (first)
            {
                case "Санкт-Петербурга"://1+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "608 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "634 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "776 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1135 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "817 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "995 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1074 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1167 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1370 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1492 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "1251 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1380 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "1359 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "1418 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1632 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1783 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "1351 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1200 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2043 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1910 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1779 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1545 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1540 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3576 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1906 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1719 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3106 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2585 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3131 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3257 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3255 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3411 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3576 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4416 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6196 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6539 км";

                        }


                        break;
                    }
                case "Ярославля"://2+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "608 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "251 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "407 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "288 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "333 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "559 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "666 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "588 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "804 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "967 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "643 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "791 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "752 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "810 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1042 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1245 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "784 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "599 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1529 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1346 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1171 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1038 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1157 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1402 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1370 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1513 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2624 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2624 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2678 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2792 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2756 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2931 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3147 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3996 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5907 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6194 км";
                        }


                        break;
                    }
                case "Москвы"://3+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "635 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "251 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "173 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "402 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "184 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "373 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "467 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "555 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "968 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1156 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "703 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "924 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "798 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "855 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1165 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1417 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "726 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "719 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1711 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1494 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1228 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "912 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "959 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1196 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1271 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1273 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2812 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2236 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2878 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2987 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2934 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3118 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3354 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4203 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6142 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6410 км";
                        }


                        break;
                    }
                case "Тулы"://4+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "776 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "407 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "173 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "469 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "146 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "220 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "302 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "498 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1023 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1226 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "698 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "698 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "776 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "829 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1183 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1470 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "638 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "754 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1769 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1526 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1198 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "774 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "789 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1023 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1142 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1106 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2868 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2281 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2945 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3049 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2981 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3172 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3427 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4275 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6246 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6507 км";
                        }


                        break;
                    }
                case "Нижнего Новгорода"://5+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "896 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "288 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "402 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "469 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "328 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "503 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "607 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "354 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "566 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "761 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "356 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "525 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "466 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "524 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "772 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1016 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "550 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "324 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1312 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1094 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "883 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "848 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1054 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1144 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1304 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2412 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1835 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2482 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2589 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2533 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2718 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2962 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3810 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5779 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6038 км";
                        }


                        break;
                    }
                case "Рязани"://6+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "817 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "333 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "184 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "146 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "328 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "328 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "333 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "379 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "877 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1082 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "558 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "812 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "642 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "697 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1040 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1324 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "543 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "609 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1623 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1381 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1069 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "736 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "824 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1069 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1090 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1090 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2723 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2135 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2800 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2901 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2831 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3027 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3282 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4129 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6107 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6364 км";
                        }


                        break;
                    }
                case "Липецка"://7+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "995 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "559 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "373 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "220 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "503 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "225 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "109 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "369 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "992 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1209 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "611 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "902 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "663 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "708 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1101 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1423 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "456 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "713 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1724 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1452 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1059 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "555 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "598 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "843 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "924 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "995 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2812 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2213 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2903 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2999 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2913 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3112 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3391 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4234 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6250 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6486 км";
                        }


                        break;
                    }
                case "Воронежа"://8+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1074 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "666 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "467 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "214 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "607 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "330 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "109 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "428 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1075 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1295 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "680 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "978 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "719 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "758 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1163 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1497 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "471 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "796 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1797 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1515 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1093 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "500 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "494 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "736 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "872 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "890 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2879 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2276 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2975 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3068 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2974 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3176 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3465 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4304 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6336 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6563 км";
                        }


                        break;
                    }
                case "Пензы"://9+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1167 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "588 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "555 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "498 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "354 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "379 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "369 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "428 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "663 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "885 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "253 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "555 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "295 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "341 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "735 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1071 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "199 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "392 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1371 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1087 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "702 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "500 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "764 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1008 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "792 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1269 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2450 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1848 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2548 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2640 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2547 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2749 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3037 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3876 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5917 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6137 км";
                        }


                        break;
                    }
                case "Ижевска"://10+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1370 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "804 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "968 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1023 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "566 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "877 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "992 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1075 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1332 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "222 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "416 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "135 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "444 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "453 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "293 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "450 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "754 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "279 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "747 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "543 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "580 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1077 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1410 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1644 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1222 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1931 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2152 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1269 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1923 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2026 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1967 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2152 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2406 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3253 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5260 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5495 км";
                        }


                        break;
                    }
                case "Перми"://11+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1492 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1492 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1156 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1226 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "761 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1082 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1209 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1295 км";
                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "885 км";
                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "222 км";
                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "638 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "344 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "658 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "659 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "366 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "292 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "972 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "498 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "562 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "448 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "699 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1291 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1631 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1863 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1411 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "2153 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1659 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1100 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1722 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1831 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1789 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "1965 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2202 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3050 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5041 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5283 км";
                        }


                        break;
                    }
                case "Ульяновска"://12+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1251 км";
                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "643 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "703 км";
                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "698 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "356 км";
                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "558 км";
                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "611 км";
                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "680 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "253 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "416 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "638 км";
                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "0 км";
                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "302 км";
                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "112 км";
                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "169 км";
                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "494 км";
                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "818 км";
                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "346 км";
                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "171 км";
                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1118 км";
                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "841 км";
                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "531 км";
                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "677 км";
                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "995 км";
                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1231 км";
                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "886 км";
                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1516 км";
                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2202 км";
                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1602 км";
                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2296 км";
                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2390 км";
                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2303 км";
                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2501 км";
                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2785 км";
                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3625 км";
                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5665 км";
                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5884 км";
                        }


                        break;
                    }
                case "Набережных Челнов"://13+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1380 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "791 км";
                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "924 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "957 км";
                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "525 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "812 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "902 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "978 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "555 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "135 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "344 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "302 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "314 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "319 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "252 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "521 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "628 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "205 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "822 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "571 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "476 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "947 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1289 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1519 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1088 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1817 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1915 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1323 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2001 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2099 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2024 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2217 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2489 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3332 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5362 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5586 км";

                        }


                        break;
                    }
                case "Тольятти"://14+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1359 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "752 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "798 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "776 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "466 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "642 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "663 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "719 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "295 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "444 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "658 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "112 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "314 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "59 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "447 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "800 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "317 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "253 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1095 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "798 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "430 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "634 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "980 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1207 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "803 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1518 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2162 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1558 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2265 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2354 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2255 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2459 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2756 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3592 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5653 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5859 км";

                        }


                        break;
                    }
                case "Самары"://15+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1418 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "810 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "855 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "829 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "524 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "697 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "708 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "758 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "341 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "453 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "659 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "169 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "319 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "59 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "418 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "781 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "333 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "294 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1071 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "766 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "373 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "634 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "994 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1215 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "776 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1538 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2129 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1523 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2236 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2322 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2218 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2424 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2728 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3560 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5631 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5831 км";

                        }


                        break;
                    }
                case "Уфы"://16+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1632 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1042 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1165 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1183 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "772 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1040 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1101 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1163 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "735 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "293 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "366 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "492 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "252 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "447 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "420 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "374 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "751 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "450 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "654 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "351 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "335 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1033 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1406 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1619 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1087 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1954 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1715 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1112 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1818 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1906 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1811 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2012 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2308 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3144 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5214 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5412 км";

                        }


                        break;
                    }
                case "Екатеринбурга"://17+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1782 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1245 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1416 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1469 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1015 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1324 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1422 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1497 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1070 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "449 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "292 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "715 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "520 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "800 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "781 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "373 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "1113 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "717 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "301 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "193 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "667 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1404 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1773 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1990 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1450 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "2316 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1399 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "821 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1481 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1581 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1839 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "1704 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "1960 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2812 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "4853 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5067 км";

                        }


                        break;
                    }
                case "Саратова"://18+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1351 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "784 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "726 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "637 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "549 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "543 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "456 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "472 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "197 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "753 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "971 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "348 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "628 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "317 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "332 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "751 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1113 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "516 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1404 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1094 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "626 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "332 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "662 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "891 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "595 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1204 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2454 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1845 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2566 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2649 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2536 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2746 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3057 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3888 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5664 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6161 км";

                        }

                        break;
                    }
                case "Казани"://19+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1200 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "598 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "718 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "754 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "322 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "608 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "712 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "797 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "392 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "279 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "497 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "171 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "206 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "255 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "296 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "450 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "717 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = " 516";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1018 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "777 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "596 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "848 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1152 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1393 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1054 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1659 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2115 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1527 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2197 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2298 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2227 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2419 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2682 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3528 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5539 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5774 км";

                        }

                        break;
                    }
                case "Тюмени"://20+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "2042 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1529 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1711 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1769 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1311 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1623 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1723 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1797 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1369 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "747 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "563 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "171 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "821 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "1094 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "1071 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "654 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "3041 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "1404 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1018 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "339 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "901 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1683 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "2059 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "2269 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1693 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "2607 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1101 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "542 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1180 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1281 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1226 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "1407 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "1667 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2511 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "4560 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "4767 км";

                        }

                        break;
                    }
                case "Челябинска"://21+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1910 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1346 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1494 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1526 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1094 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1381 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1452 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1515 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1087 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "543 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "448 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "841 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "571 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "798 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "766 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "352 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "193 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "1095 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "776 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "339 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "562 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "1357 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1741 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1943 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1354 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "2295 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1364 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "761 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1471 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1471 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1461 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "1662 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "1963 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2795 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "4879 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5066 км";

                        }


                        break;
                    }
                case "Оренбурга"://22+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1779 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1171 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1228 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1198 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "883 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1069 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "1059 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "1093 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "702 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "702 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "699 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "531 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "476 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "430 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "373 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "334 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "667 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "624 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "594 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "901 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "562 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "825 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "1218 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "1402 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "792 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1778 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1868 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1260 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1998 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2068 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1934 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2149 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2488 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "3301 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "5421 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "5584 км";

                        }


                        break;
                    }
                case "Волгограда"://23+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1545 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1038 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "912 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "774 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "848 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "736 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "555 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "500 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "500 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "543 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1077 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "677 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "947 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "634 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "634 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1031 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1405 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "332 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "846 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1683 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1357 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "825 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "395 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "597 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "372 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "954 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "2692 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2084 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "2819 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2892 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2758 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2974 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3310 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4125 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6235 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6408 км";

                        }


                        break;
                    }
                case "Ростова-на-Дону"://24+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1540 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1157 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "959 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "789 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1054 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "824 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "598 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "494 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "764 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1410 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1631 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "995 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1289 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "980 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "994 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1405 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1774 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "663 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1152 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2060 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1741 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1018 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "395 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "250 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "641 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "560 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3084 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2476 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3208 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3283 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3152 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3368 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3699 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4518 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6619 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6799 км";

                        }

                        break;
                    }
                case "Краснодара"://25+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1755 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1402 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1196 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1023 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1304 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1069 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "843 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "736 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1008 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1644 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1863 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "1231 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1519 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "980 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "1207 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1618 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1990 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "891 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1392 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2270 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1943 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1402 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "587 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "250 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "718 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "428 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3268 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2661 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3399 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3469 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3325 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3544 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3890 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4698 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6820 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6983 км";

                        }

                    


                        break;
                    }
                case "Астрахани"://26+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1906 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1370 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1217 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1142 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1144 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1090 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "924 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "872 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "792 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1222 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1411 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "886 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1088 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "803 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "776 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1085 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1450 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "594 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1052 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1693 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1354 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1402 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "794 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "641 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "718 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "1146 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3669 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2013 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3399 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "2811 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "2648 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "2871 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3239 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "4026 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "6181 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "6311 км";

                        }   


                        break;
                    }
                case "Севастополя"://27+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "1719 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "1512 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "1273 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "1106 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1497 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "1201 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "995 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "890 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1296 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1931 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "2153 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "1516 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1817 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "1518 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "1538 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1954 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "2318 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "1205 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1660 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2609 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "2295 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1778 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "954 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "560 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "428 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "1146 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3646 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "3035 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3764 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3842 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3712 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3927 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "4256 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "5077 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "7169 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "7358 км";

                        }


                        break;
                    }
                case "Новосибирска"://28+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3106 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2624 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "2812 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "2868 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2412 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "2723 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "2812 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "2879 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "2450 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1847 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1659 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "2202 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1915 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2162 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2129 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1716 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1398 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2454 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2115 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1101 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1364 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1868 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2692 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3084 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3268 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2608 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3646 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "609 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "206 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "204 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "195 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "307 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "635 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "1434 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "3576 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3716 км";

                        }


                        break;
                    }
                case "Омска"://29+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "2585 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2065 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "2236 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "2281 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "1835 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "2135 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "2213 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "2276 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "1848 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1269 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1100 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "1602 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "1323 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "1558 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "1523 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1113 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "820 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2454 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "1527 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "542 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "761 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1260 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2074 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "2476 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "2661 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2013 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3035 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "609 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "743 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "812 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "701 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "901 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "1229 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2043 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "4169 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "4324 км";

                        }


                        break;
                    }
                case "Томска"://30+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3131 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2678 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "2878 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "2945 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2482 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "2800 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "2903 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "2975 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "2548 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1923 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1953 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "2296 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "2001 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2265 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2236 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1819 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1481 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2556 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2197 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1180 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1471 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1998 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2819 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3208 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3399 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2756 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3764 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "206 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "743 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "145 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "357 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "334 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "492 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "1331 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "3426 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3595 км";

                        }


                        break;
                    }   
                case "Кемерова"://31+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3257 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2792 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "2987 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "3049 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2589 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "2903 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "2999 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "3068 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "2340 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "2026 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1831 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "2390 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "2099 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2354 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2322 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1907 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1580 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2649 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2297 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1280 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1557 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "2068 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2892 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3283 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3469 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2811 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3842 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "204 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "808 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "145 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "296 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "190 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "431 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "1238 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "3372 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3516 км";

                        }


                        break;
                    }
                case "Барнаула"://32+ 
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3255 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2756 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "2934 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "2981 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2533 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "2836 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "2913 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "2974 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "2547 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "1967 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1789 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "2303 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "2024 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2255 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2218 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "1812 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1517 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2537 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2227 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1227 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1461 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "1934 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2758 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3152 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3325 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2648 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3712 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "195 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "701 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "357 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "296 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "226 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "655 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "1378 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "3558 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3663 км";

                        }


                        break;
                    }
                case "Новокузнецка"://33+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3411 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "2931 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "3118 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "3172 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2718 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "3027 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "3112 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "3176 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "2749 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "2152 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "1965 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "1889 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "2217 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2459 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2424 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "2013 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1703 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "2746 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2227 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2418 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1662 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "2149 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "2974 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3368 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3544 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "2871 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "3927 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "307 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "901 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "334 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "190 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "226 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "444 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "1156 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "3332 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3663 км";

                        }


                        break;
                    }
                case "Красноярска"://34+
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "3576 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "3147 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "3354 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "3427 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "2962 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "3282 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "3391 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "3465 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "3037 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "2406 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "2202 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "2785 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "2489 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "2756 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "2728 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "2310 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "1968 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "3058 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "2682 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "1668 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "1963 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "2488 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "3310 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "3699 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "3890 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "3239 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "4256 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "635 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "1229 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "492 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "431 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "655 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "444 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "849 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "2942 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "3103 км";

                        }


                        break;
                    }
                case "Иркутска"://35
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "4416 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "3996 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "4203 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "4275 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "3810 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "4129 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "4234 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "4304 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "3876 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "3253 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "3050 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "3625 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "3332 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "3592 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "3560 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "3145 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "2811 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "3887 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "3527 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "2510 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "2795 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "3301 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "4125 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "4518 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "4698 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "4026 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "5077 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "1434 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "2043 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "1331 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "1238 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "1378 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "1434 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "849 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "2207 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "2285 км";

                        }


                        break;
                    }
                case "Хабаровска"://36
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "6196 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "5907 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "6142 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "6246 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "5779 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "6107 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "6250 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "6336 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "5917 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "5260 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "5041 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "5665 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "5362 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "5653 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "5631 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "5215 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "4852 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "5964 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "5539 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "4560 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "4879 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "5421 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "6235 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "6619 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "6820 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "6181 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "7169 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3576 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "4169 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3426 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3372 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3558 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3332 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "2942 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2207 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "0 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "646 км";

                        }


                        break;
                    }
                case "Владивостока"://37
                    {
                        if (second == "Санкт-Петербурга")
                        {
                            Rs.Text = "6539 км";

                        }
                        if (second == "Ярославля")
                        {
                            Rs.Text = "6194 км";

                        }
                        if (second == "Москвы")
                        {
                            Rs.Text = "6418 км";

                        }
                        if (second == "Тулы")
                        {
                            Rs.Text = "6507 км";

                        }
                        if (second == "Нижнего Новгорода")
                        {
                            Rs.Text = "6038 км";

                        }
                        if (second == "Рязани")
                        {
                            Rs.Text = "6364 км";

                        }
                        if (second == "Липецка")
                        {
                            Rs.Text = "6486 км";

                        }
                        if (second == "Воронежа")
                        {
                            Rs.Text = "6563 км";

                        }
                        if (second == "Пензы")
                        {
                            Rs.Text = "6137 км";

                        }
                        if (second == "Ижевска")
                        {
                            Rs.Text = "5495 км";

                        }
                        if (second == "Перми")
                        {
                            Rs.Text = "5283 км";

                        }
                        if (second == "Ульяновска")
                        {
                            Rs.Text = "5884 км";

                        }
                        if (second == "Набережных Челнов")
                        {
                            Rs.Text = "5586 км";

                        }
                        if (second == "Тольятти")
                        {
                            Rs.Text = "5859 км";

                        }
                        if (second == "Самары")
                        {
                            Rs.Text = "5831 км";

                        }
                        if (second == "Уфы")
                        {
                            Rs.Text = "5413 км";

                        }
                        if (second == "Екатеринбурга")
                        {
                            Rs.Text = "5066 км";

                        }
                        if (second == "Саратова")
                        {
                            Rs.Text = "6161 км";

                        }
                        if (second == "Казани")
                        {
                            Rs.Text = "5774 км";

                        }
                        if (second == "Тюмени")
                        {
                            Rs.Text = "4767 км";

                        }
                        if (second == "Челябинска")
                        {
                            Rs.Text = "2066 км";

                        }
                        if (second == "Оренбурга")
                        {
                            Rs.Text = "5584 км";

                        }
                        if (second == "Волгограда")
                        {
                            Rs.Text = "6408 км";

                        }
                        if (second == "Ростова-на-Дону")
                        {
                            Rs.Text = "6799 км";

                        }
                        if (second == "Краснодара")
                        {
                            Rs.Text = "6983 км";

                        }
                        if (second == "Астрахани")
                        {
                            Rs.Text = "6311 км";

                        }
                        if (second == "Севастополя")
                        {
                            Rs.Text = "7358 км";

                        }
                        if (second == "Новосибирска")
                        {
                            Rs.Text = "3716 км";

                        }
                        if (second == "Омска")
                        {
                            Rs.Text = "4324 км";

                        }
                        if (second == "Томска")
                        {
                            Rs.Text = "3595 км";

                        }
                        if (second == "Кемерова")
                        {
                            Rs.Text = "3516 км";

                        }
                        if (second == "Барнаула")
                        {
                            Rs.Text = "3663 км";

                        }
                        if (second == "Новокузнецка")
                        {
                            Rs.Text = "3441 км";

                        }
                        if (second == "Красноярска")
                        {
                            Rs.Text = "3103 км";

                        }
                        if (second == "Иркутска")
                        {
                            Rs.Text = "2285 км";

                        }
                        if (second == "Хабаровска")
                        {
                            Rs.Text = "646 км";

                        }
                        if (second == "Владивостока")
                        {
                            Rs.Text = "0 км";

                        }


                        break;
                    }
            }
        }

        public string[] que = new string[50] {
            "в каком городе население больше",
            "в каком городе население больше",
            "в каком городе население больше",
            "в каком городе население больше",
            "в каком городе население больше",
            "в каком городе население меньше",
            "в каком городе население меньше",
            "в каком городе население меньше",
            "в каком городе население меньше",
            "в каком городе население меньше",
            "В каком из этих городов максимальная температура была выше",
            "В каком из этих городов максимальная температура была выше",
            "В каком из этих городов максимальная температура была выше",
            "В каком из этих городов максимальная температура была выше",
            "В каком из этих городов максимальная температура была выше",
            "В каком из этих городов максимальная температура была меньше",
            "В каком из этих городов максимальная температура была меньше",
            "В каком из этих городов максимальная температура была меньше",
            "В каком из этих городов максимальная температура была меньше",
            "В каком из этих городов максимальная температура была меньше",
            "В каком из этих городов минимальная температура была выше",
            "В каком из этих городов минимальная температура была выше",
            "В каком из этих городов минимальная температура была выше",
            "В каком из этих городов минимальная температура была выше",
            "В каком из этих городов минимальная температура была выше",
            "В каком из этих городов минимальная температура была меньше",
            "В каком из этих городов минимальная температура была меньше",
            "В каком из этих городов минимальная температура была меньше",
            "В каком из этих городов минимальная температура была меньше",
            "В каком из этих городов минимальная температура была меньше",
            "Площадь какого города больше",
            "Площадь какого города больше",
            "Площадь какого города больше",
            "Площадь какого города больше",
            "Площадь какого города больше",
            "Площадь какого города меньше",
            "Площадь какого города меньше",
            "Площадь какого города меньше",
            "Площадь какого города меньше",
            "Площадь какого города меньше",
            "В каком часовом поясе находится Москва",
            "В каком часовом поясе находится Липецк",
            "В каком часовом поясе находится Оренбург",
            "В каком часовом поясе находится Иркутск",
            "В каком часовом поясе находится Кемерово",
            "В каком часовом поясе находится Владивосток",
            "В каком часовом поясе находится Томск",
            "В каком часовом поясе находится Севастополь",
            "В каком часовом поясе находится Астрахань",
            "В каком часовом поясе находится Екатеринбург",
            
        };
        public string[] tru = new string[50] {
            "Москва",
            "Владивосток",
            "Краснодар",
            "Воронеж",
            "Нововсибирск",
            "Тюмень",
            "Томск",
            "Севастополь",
            "Омск",
            "Набережные челны",
            "Москва",
            "Кемерово",
            "Казань",
            "Волгоград",
            "Санкт-Петербург",
            "Липецк",
            "Хабаровск",
            "в каком городе население меньше",
            "Севастополь",
            "Красноярск",
            "Липецк",
            "Владивосток",
            "Кемерово",
            "Хабаровск",
            "Севастополь",//25
            "Краснодар",
            "Кемерово",
            "Нижний Новгород",
            "Москва",
            "Красноярск",//1
            "Томск",//2
            "Севастополь",//3
            "Хабаровск",//4
            "Уфа",//5
            "Санкт-Петербург",
            "Севастополь",
            "Рязань",
            "Нижний Новгород",
            "Барнаул",
            "Новокузнецк",
            "UTC+3",
            "UTC+3",
            "UTC+5",
            "UTC+8",
            "UTC+7",
            "UTC+10",
            "UTC+7",
            "UTC+3",
            "UTC+4",
            "UTC+5",
        };
        public string[] b = new string[50] {
            "Санкт-Петербург",
            "Томск",
            "Новокузнецк",
            "Хабаровск",
            "Иркутск",
            "Екатеринбург",
            "Красноярск",
            "Уфа",
            "Москва",
            "Санкт-Петербург",
            "Ярославль",
            "Пермь",
            "Севастополь",
            "Ростов-на-Дону",
            "Красноярск",
            "в каком городе население меньше",
            "Челябинск",
            "Барнаул",
            "Астрахань",
            "Екатеринбург",
            "Ярославль",
            "Тюмень",
            "Уфа",
            "Иркутск",
            "Пермь",//25
            "Севастополь",
            "Ярославль",
            "Владивосток",
            "Астрахань",
            "Новосибирск",
            "Ярославль",//1
            "Казань",//2
            "Красноярск",//3
            "Тюмень",//4
            "Саратов",//5
            "Санкт-Петербург",
            "Красноярск",
            "Екатеринбург",
            "Челябинск",
            "Новокузнецк",
            "UTC+4",
            "UTC+5",
            "UTC+4",
            "UTC+7",
            "UTC+8",
            "UTC+6",
            "UTC+8",
            "UTC+2",
            "UTC+8",
            "UTC-1",
        };
        public string[] d = new string[50] {
            "Красноярск",
            "Оренбург",
            "Кемерово",
            "Пермь",
            "Челябинск",
            "Нижний Новгород",
            "Хабаровск",
            "Барнаул",
            "Новосибирск",
            "Иркутск",
            "Липецк",
            "Новокузнецк",
            "Барнаул",
            "Оренбург",
            "Ижевск",
            "Новокузнецк",
            "Иркутск",
            "Москва",
            "Волгоград",
            "Санкт-Петербург",
            "Омск",
            "Оренбург",
            "Барнаул",
            "Нижний Новгород",
            "Новосибирск",//25
            "Липецк",
            "Омск",
            "Пенза",
            "Москва",
            "Барнаул",
            "Иркутск",//1
            "Нижний Новгопод",//2
            "Астрахань",//3
            "Воронеж",//4
            "Новосибирск",//5
            "Москва",
            "Томск",
            "Новокузнецк",
            "Хабаровск",
            "Санкт-Петербург",
            "UTC+6",
            "UTC+2",
            "UTC+1",
            "UTC+10",
            "UTC+6",
            "UTC+8",
            "UTC+9",
            "UTC+4",
            "UTC+10",
            "UTC+8",
        };
        public string[] p = new string[10];
        public int[] p2 = new int[10];
        public static Random rand = new Random();
        int namber = rand.Next(0, 50);
        public static int count;
        public static int mark2;
        public static int y = 50;
        public static bool vh = false;

        private void Retry(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(i.Text) <= 50) && (Convert.ToInt32(i.Text) > 0))
                {
                    y = Convert.ToInt32(i.Text);
                }
                else
                {
                    i.Text = "50";
                }
            }
            catch (FormatException)
            {
                i.Text = "50";
            }
            vh = true;

            namber = rand.Next(0, 50);
            mark2 = 0;
            count = 1;
            mark.Text = "Ваши очки 0 из 0"; 
            m2ark.Text = "0%";
            b6.Text = "";
            q.Text = que[namber];
            int s = rand.Next(1, 7);
            switch (s)
            {
                case 1 :
                    {
                        a3.Text = tru[namber];
                        b3.Text = b[namber];
                        c3.Text = d[namber];
                        break;
                    }
                case 2 :
                    {
                        a3.Text = tru[namber];
                        b3.Text = d[namber];
                        c3.Text = b[namber];
                        break;
                    }
                 case 3 :
                    {
                        a3.Text = b[namber];
                        b3.Text = tru[namber];
                        c3.Text = d[namber];
                        break;
                    }
                 case 4 :
                    {
                        a3.Text = b[namber];
                        b3.Text = d[namber];
                        c3.Text = tru[namber];
                        break;
                    }
                  case 5 :
                    {
                        a3.Text = d[namber];
                        b3.Text = tru[namber];
                        c3.Text = b[namber];
                        break;
                    }
                  case 6 :
                    {
                        a3.Text = d[namber];
                        b3.Text = b[namber];
                        c3.Text = tru[namber];
                        break;
                    }


            }
        }
        private void nEXT(object sender, RoutedEventArgs e)
        {
            int kf = 0;
            if ((count <= y) && (vh))
            {
             /*   a3.Foreground = new SolidColorBrush(Color.FromArgb(217, 22, 22, 1));
                b3.Foreground = new SolidColorBrush(Color.FromArgb(217, 22, 22, 1));
                c3.Foreground = new SolidColorBrush(Color.FromArgb(217, 22, 22, 1));*/

                if (rad1.IsChecked == true)
                {
                    if (a3.Text == tru[namber])
                    {
                        mark2++;
                    }
                }
                if (rad2.IsChecked == true)
                {
                if (b3.Text == tru[namber])
                    {
                        mark2++;
                    }
                }
                if (rad3.IsChecked == true)
                {
                    if (c3.Text == tru[namber])
                    {
                        mark2++;
                    }
                }

               /* if (a3.Text == tru[namber])
                {
                    a3.Foreground = new SolidColorBrush(Color.FromArgb(104, 205, 116, 1));
                }
                {
                    a3.Foreground = new SolidColorBrush(Color.FromArgb(104, 205, 116, 1));
                    mark2++;
                }
                if (c3.Text == tru[namber])
                {
                    a3.Foreground = new SolidColorBrush(Color.FromArgb(104, 205, 116, 1));
                    mark2++;
                }*/

               // System.Threading.Thread.Sleep(200);

                mark.Text = "Ваши баллы " + Convert.ToString(mark2) + " из " + Convert.ToString(count);
                if (count != 0)
                {
                    m2ark.Text = Convert.ToString(Math.Round(Convert.ToDouble(mark2 * 100 / count))) + "%";
                    kf = Convert.ToInt32(Math.Round(Convert.ToDouble(mark2 * 100 / count)));
                    if ((Math.Round(Convert.ToDouble(mark2 * 100 / count)) == 0) && (mark2 > 0))
                    {
                        m2ark.Text = "1%";
                        kf = 1;
                    }
                }
                count++;
                namber = rand.Next(0, que.Length);
                int s = rand.Next(1, 7);
                q.Text = que[namber];

                switch (s)
                {

                case 1:
                    {
                        a3.Text = tru[namber];
                        b3.Text = b[namber];
                        c3.Text = d[namber];
                        break;
                    }
                case 2:
                    {
                        a3.Text = tru[namber];
                        b3.Text = d[namber];
                        c3.Text = b[namber];
                        break;
                    }
                case 3:
                    {
                        a3.Text = b[namber];
                        b3.Text = tru[namber];
                        c3.Text = d[namber];
                        break;
                    }
                case 4:
                    {
                        a3.Text = b[namber];
                        b3.Text = d[namber];
                        c3.Text = tru[namber];
                        break;
                    }
                case 5:
                    {
                        a3.Text = d[namber];
                        b3.Text = tru[namber];
                        c3.Text = b[namber];
                        break;
                    }
                case 6:
                    {
                        a3.Text = d[namber];
                        b3.Text = b[namber];
                        c3.Text = tru[namber];
                        break;
                    }
            }
                
            }
            
            if ((count > y) && (vh))
            {
                mark.Text = "Ваши баллы " + Convert.ToString(mark2) + " из " + Convert.ToString(y);
                if ((Math.Round(Convert.ToDouble(mark2 * 100 / count)) == 0) && (mark2 > 0))
                {
                    m2ark.Text = "1%";
                    kf = 1;
                }
                if (kf >= 90)
                {
                    b6.Text = "Ваша оценка 5";
                }
                if ((kf <= 89) && (kf >= 70))
                {
                    b6.Text = "Ваша оценка 4";
                }
                if ((kf <= 69) && (kf >= 50))
                {
                    b6.Text = "Ваша оценка 3";
                }
                if ((kf <= 49))
                {
                    b6.Text = "Ваша оценка 2";
                }


                if (kf > p2[9])
                {
                    if (kf > p2[8])
                    {
                        if (kf > p2[7])
                        {
                            if (kf > p2[6])
                            {
                                if (kf > p2[5])
                                {
                                    if (kf > p2[4])
                                    {
                                        if (kf > p2[3])
                                        {
                                            if (kf > p2[2])
                                            {
                                                if (kf > p2[1])
                                                {
                                                    if (kf > p2[0])
                                                    {
                                                        for (int i = 9; i > 0; i--)
                                                        {
                                                            p[i] = p[i - 1];
                                                            p2[i] = p2[i - 1];
                                                        }
                                                        p[0] = "" + rt.Text + "    " + Convert.ToString(kf) + "%";
                                                        p2[0] = kf;
                                                    }
                                                    else
                                                    {
                                                        for (int i = 9; i > 1; i--)
                                                        {
                                                            p[i] = p[i - 1];
                                                            p2[i] = p2[i - 1];
                                                        }
                                                        p[1] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                                        p2[1] = kf;
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 9; i > 2; i--)
                                                    {
                                                        p[i] = p[i - 1];
                                                        p2[i] = p2[i - 1];
                                                    }
                                                    p[2] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                                    p2[2] = kf;
                                                }
                                            }
                                            else
                                            {
                                                for (int i = 9; i > 3; i--)
                                                {
                                                    p[i] = p[i - 1];
                                                    p2[i] = p2[i - 1];
                                                }
                                                p[3] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                                p2[3] = kf;
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 9; i > 4; i--)
                                            {
                                                p[i] = p[i - 1];
                                                p2[i] = p2[i - 1];
                                            }
                                            p[4] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                            p2[4] = kf;
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 9; i > 5; i--)
                                        {
                                            p[i] = p[i - 1];
                                            p2[i] = p2[i - 1];
                                        }

                                        p[5] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                        p2[5] = kf;
                                    }
                                }
                                else
                                {
                                    for (int i = 9; i > 6; i--)
                                    {
                                        p[i] = p[i - 1];
                                        p2[i] = p2[i - 1];
                                    }
                                    p[6] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                    p2[6] = kf;
                                }
                            }
                            else
                            {

                                for (int i = 9; i > 7; i--)
                                {
                                    p[i] = p[i - 1];
                                    p2[i] = p2[i - 1];
                                }
                                p[7] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                                p2[7] = kf;
                            }
                        }
                        else
                        {
                            for (int i = 9; i > 8; i--)
                            {
                                p[i] = p[i - 1];
                                p2[i] = p2[i - 1];
                            }
                            p[8] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                            p2[8] = kf;
                        }
                    }
                    else
                    {
                        p[9] = "" + rt.Text + "    " + Convert.ToString(kf) + "%"; ;
                        p2[9] = kf;
                    }

                }

                h1.Text = "1. " + p[0];
                h2.Text = "2. " + p[1];
                h3.Text = "3. " + p[2];
                h4.Text = "4. " + p[3];
                h5.Text = "5. " + p[4];
                h6.Text = "6. " + p[5];
                h7.Text = "7. " + p[6];
                h8.Text = "8. " + p[7];
                h9.Text = "9. " + p[8];
                h10.Text = "10. " + p[9];
                vh = false;


            }

            rad1.IsChecked = false;
            rad2.IsChecked = false;
            rad3.IsChecked = false;
        }
    }
} 