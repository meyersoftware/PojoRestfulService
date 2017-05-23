using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PojoRestfulService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public double[] Get()
        {
            List<string[]> oCsvList = ReadFile();

            int iColumnNumber = 1;
            int iRowNumber = 1;

            double[] values = new double[14];

            for(iRowNumber = 2; iRowNumber < 15; iRowNumber++ )
            {
                values[iRowNumber-2] = double.Parse(oCsvList[iColumnNumber][iRowNumber]);
            }

            grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1 test = new grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1();

            double[] preds = new double[14];

            test.score0(values, preds);

            return preds;
        }

        // GET api/values/5
        public double[] Get(int year, double team1, double team2)
        {
            List<string[]> oCsvList = ReadFile();

            int iColumnNumber = 0;
            int iRowNumber = 0;

            for (iColumnNumber=0; iColumnNumber <= oCsvList.Count; iColumnNumber++)
            {
                if (oCsvList[iColumnNumber][iRowNumber].ToString() == year.ToString() + "_" + team1.ToString() + "_" + team2.ToString())
                {
                    break;
                }
            }

            double[] values = new double[14];

            for (iRowNumber = 2; iRowNumber < 15; iRowNumber++)
            {
                values[iRowNumber - 2] = double.Parse(oCsvList[iColumnNumber][iRowNumber]);
            }

            grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1 test = new grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1();

            double[] preds = new double[14];

            test.score0(values, preds);

            return preds;
        }

        [System.Web.Http.HttpGet]
        public string[] GetTeamList()
        {
            List<string[]> oCsvList = ReadFile();

            int iColumnNumber = 0;
            int iRowNumber = 0;

            List<string> teams = new List<string>();
            string previousTeam = "";

            for (iColumnNumber = 1; iColumnNumber < oCsvList.Count; iColumnNumber++)
            {
                try
                {
                    if (oCsvList[iColumnNumber][iRowNumber].ToString().Substring(5, 4) != previousTeam)
                    {
                        teams.Add(oCsvList[iColumnNumber][iRowNumber].ToString().Substring(5, 4));
                        previousTeam = oCsvList[iColumnNumber][iRowNumber].ToString().Substring(5, 4);
                    }
                }
                catch (Exception ex)
                { //do nothing
                }
            }
            return teams.ToArray<string>();
        }

        [System.Web.Http.HttpGet]
        public string[] GetOpposingTeamList(string team)
        {
            List<string[]> oCsvList = ReadFile();

            int iColumnNumber = 0;
            int iRowNumber = 0;

            List<string> teams = new List<string>();
            
            string previousTeam = "";

            for (iColumnNumber = 1; iColumnNumber < oCsvList.Count; iColumnNumber++)
            {
                try
                {
                    if (oCsvList[iColumnNumber][iRowNumber].ToString().Substring(5, 4) == team)
                    {
                        if (oCsvList[iColumnNumber][iRowNumber].ToString().Substring(10, 4) != previousTeam)
                        {
                            teams.Add(oCsvList[iColumnNumber][iRowNumber].ToString().Substring(10, 4));
                            previousTeam = oCsvList[iColumnNumber][iRowNumber].ToString().Substring(10, 4);
                        }
                    }
                }
                catch (Exception ex)
                { //do nothing
                }
            }
            return teams.ToArray<string>();
        }

        private static List<string[]> ReadFile()
        {
            string sFileContents = "";

            var url = "http://pwp.apphb.com//mm2017Matchups.csv";
            //var url = "http://localhost:50209/mm2017Matchups.csv";

            WebClient wc = new WebClient();

            using (StreamReader oStreamReader = new StreamReader(wc.OpenRead(url)))
            {
                sFileContents = oStreamReader.ReadToEnd();
            }

            List<string[]> oCsvList = new List<string[]>();

            string[] sFileLines = sFileContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string sFileLine in sFileLines)
            {
                oCsvList.Add(sFileLine.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
            }

            return oCsvList;
        }
    }
}
