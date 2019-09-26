using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getWeatherDetails();
        }

        void getWeatherDetails()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id=588409&appid=8e4dcb3a1ab522971456c7b7bbfb55da&units=metric");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherDetails.root>(json);

                WeatherDetails.root outPut = result;

                lbl_City.Text = outPut.name + ", " + string.Format("{0}", outPut.sys.country);

                double temp = outPut.main.temp;
                lbl_temp.Text = String.Format("{0} \u00B0C", Convert.ToString(Math.Round(temp,0)));
                //lbl_temp.Text = (string.Format("{0}\u00B0", outPut.main.temp));

                lbl_windspeed.Text = string.Format("{0} m/s", outPut.wind.speed);
                lbl_pressure.Text = string.Format("{0} hPa", outPut.main.pressure);
                lbl_humidity.Text = string.Format("{0 }%", outPut.main.humidity);

                String culture = "et-EE";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);

                //convert unix to datetime - Current Time
                DateTime localDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(string.Format("{0}", outPut.dt))).DateTime.ToLocalTime();
                // convert unix to time - sunrise & set
                DateTime sunRise = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(string.Format("{0}", outPut.sys.sunrise))).DateTime.ToLocalTime();
                DateTime sunSet = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(string.Format("{0}", outPut.sys.sunset))).DateTime.ToLocalTime();

                lbl_dateTime.Text = Convert.ToString(localDateTimeOffset);
                lbl_sunrise.Text = String.Format("{0:t}", sunRise);
                lbl_sunset.Text = String.Format("{0:t}", sunSet);

                string iconName = string.Format("{0}", outPut.weather[0].icon);

                if (iconName.Contains("01"))
                {
                    lbl_icon.Image = Properties.Resources.Lighter_Heat;
                    // lbl_desc.Text = string.Format("{0}", outPut.weather[0].description);
                    lbl_desc.Text = string.Format("{0}", "Selge");

                }
                else if (iconName.Contains("02"))
                {
                    lbl_icon.Image = Properties.Resources.Sun_Behind_Clouds;
                    lbl_desc.Text = string.Format("{0}", "Vähene pilvisus");

                }
                else if (iconName.Contains("03"))
                {
                    lbl_icon.Image = Properties.Resources.Cloud;
                    lbl_desc.Text = string.Format("{0}", "Mõõdukas pilvisus");

                }
                else if (iconName.Contains("04"))
                {
                    lbl_icon.Image = Properties.Resources.Cloud_with_Outlined_Cloud;
                    lbl_desc.Text = string.Format("{0}", "Pilves");

                }
                else if (iconName.Contains("09"))
                {
                    lbl_icon.Image = Properties.Resources.Rain_with_Clouds;
                    lbl_desc.Text = string.Format("{0}", "Vähene sadu");

                }
                else if (iconName.Contains("10"))
                {
                    lbl_icon.Image = Properties.Resources.Rain;
                    lbl_desc.Text = string.Format("{0}", "Vihm");

                }
                else
                {
                    lbl_icon.Image = Properties.Resources.Snow;
                    lbl_desc.Text = string.Format("{0}", "Lumi");

                }





            }

            //translate

        }
            }

        }

                     

    
