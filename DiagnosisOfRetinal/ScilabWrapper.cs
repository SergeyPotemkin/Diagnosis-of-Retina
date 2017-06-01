
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScilabClass;
using model3D;
using SCILAB.TRANSACTION.NET.Arrays;
using SCILAB.TRANSACTION.NET.Utility;

namespace DiagnosisOfRetinal
{
    class ScilabWrapper
    {
        private ScilabClass.Class1 matlab = null;
        private String videoFilePath = null;

        public ScilabWrapper(String videoFilePath)
        {
            this.videoFilePath = videoFilePath;
            matlab = new ScilabClass.Class1();

            matlab.openVideo( (MWCharArray)videoFilePath,
                              (MWCharArray)System.IO.Path.GetFullPath(@"scan\")
                   );
        }

        private MWCellArray getCorcoefParams()
        {
            MWCellArray mwCorcoef = (MWCellArray)matlab.corcoef(
                       (MWCharArray)videoFilePath,
                       (MWCharArray)System.IO.Path.GetFullPath(@"scan\")
                   );
            return (MWCellArray)mwCorcoef;
        }

        private Double getGlobalCorcoef(MWCellArray mwCorcoef)
        {
            return ((MWNumericArray)mwCorcoef[1]).ToScalarDouble();
        }

        private MWCellArray getCriticalPointsParams()
        {
            MWCellArray mwCriticalPoints = (MWCellArray)matlab.criticalPoints(
                       (MWCharArray)videoFilePath
                   );
            return ((MWCellArray)mwCriticalPoints);
        }

        private int getGlobalCriticalPoints(MWCellArray mwCriticalPoints)
        {
            return ((MWNumericArray)mwCriticalPoints[1]).ToScalarInteger();
        }
        private int getLocalCriticalPointsCount(MWCellArray mwCriticalPoints, int snapshot_num)
        {
            return ((MWNumericArray)mwCriticalPoints[2][snapshot_num][1]).ToScalarInteger();
        }
        private double getLocalCorrelationCoef(MWCellArray mwCorcoef, int snapshot_num)
        {
            return ((MWNumericArray)mwCorcoef[2][snapshot_num][1]).ToScalarDouble();
        }

        private MWCellArray getFoveaParameters()
        {
            MWCellArray mwFovea = (MWCellArray)matlab.getFoveaParameters(
                       (MWCharArray)videoFilePath,
                       (MWCharArray)System.IO.Path.GetFullPath(@"scan\")
                   );
            return ((MWCellArray)mwFovea);
        }

        private double getFoveaWidth(int snapshot_num,MWCellArray foveaParameters)
        {
            return ((MWNumericArray)foveaParameters[snapshot_num][1]).ToScalarDouble();
        }
        private double getFoveaDepthTop(int snapshot_num, MWCellArray foveaParameters)
        {
            return ((MWNumericArray)foveaParameters[snapshot_num][2]).ToScalarDouble();
        }
        private double getFoveaDepthBottom(int snapshot_num, MWCellArray foveaParameters)
        {
            return ((MWNumericArray)foveaParameters[snapshot_num][3]).ToScalarDouble();
        }
        private double getFoveaSymmetry(int snapshot_num, MWCellArray foveaParameters)
        {
            return ((MWNumericArray)foveaParameters[snapshot_num][4]).ToScalarDouble();
        }
        private double getFoveaNormality(int snapshot_num, MWCellArray foveaParameters)
        {
            return ((MWNumericArray)foveaParameters[snapshot_num][5]).ToScalarDouble();
        }


        private MWCellArray getFoldingParameters()
        {
            MWCellArray mwFolding = (MWCellArray)matlab.getFoldingParameters(
                       (MWCharArray)videoFilePath,
                       (MWCharArray)System.IO.Path.GetFullPath(@"scan\")
                   );
            return ((MWCellArray)mwFolding);
        }
        private double getFoldingMaxAmp(int snapshot_num, MWCellArray foldingParameters)
        {
            return ((MWNumericArray)foldingParameters[snapshot_num][1]).ToScalarDouble();
        }
        private double getFoldingMinAmp(int snapshot_num, MWCellArray foldingParameters)
        {
            return ((MWNumericArray)foldingParameters[snapshot_num][2]).ToScalarDouble();
        }
        private double getFoldingMeanAmp(int snapshot_num, MWCellArray foldingParameters)
        {
            return ((MWNumericArray)foldingParameters[snapshot_num][3]).ToScalarDouble();
        }
        private int getFoldingN(int snapshot_num, MWCellArray foldingParameters)
        {
            return ((MWNumericArray)foldingParameters[snapshot_num][4]).ToScalarInteger();
        }




        public static void open3DForm(String videoFilePath)
        {
            model3D.Class1 model3D = new model3D.Class1();
            model3D.model3D((MWCharArray)videoFilePath);
        }

        public Survey getSurvey(){
            Survey survey = new Survey();

            MWCellArray mvFoveaParams = this.getFoveaParameters();
            MWCellArray mvFoldingParams = this.getFoldingParameters();
            MWCellArray mwCriticalPointsParams = this.getCriticalPointsParams();
            MWCellArray mwCorcoefParams = this.getCorcoefParams();

            survey.Global_correlation = this.getGlobalCorcoef(mwCorcoefParams);
            survey.Global_critical_points = this.getGlobalCriticalPoints(mwCriticalPointsParams);

            if (Session.isHaveSession("oldSurveyDateTime"))
            {
                survey.Date_survey = Session.getSessionItem<DateTime>("oldSurveyDateTime");
            }
            else
            {
                survey.Date_survey = DateTime.Now;
            }
            survey.ID_doctor = Session.getSessionItem<Doctor>("doctor").ID;
       
            survey.ID_patient = Session.getSessionItem<Patient>("patient").ID;

            Fovea fovea = null;
            Folding folding = null;
            Critical_points critical_points = null;
            Correlation correlation = null;
            double globalMaxAmp = 0;
            double globalMinAmp = 0;
            double globalMeanAmp = 0;
            double globalN = 0;

            double globalAllCorner = 0;
            double globalMeanCorner = 0;

            double globalFoveaLength = 0;
            double globalFoveaDepthTop = 0;
            double globalFoveaDepthBot = 0;
            double globalFoveaSymmetry = 0;
            double globalFoveaNormality = 0;
         
   
            for (int i = 1; i <= 19;i++ )
            {
                if (getFoveaWidth(i, mvFoveaParams) != 0){
                    fovea = new Fovea();
                    fovea.Num_snapshot = i;
                    fovea.Length = getFoveaWidth(i, mvFoveaParams);
                    fovea.Depth_top = getFoveaDepthTop(i, mvFoveaParams);
                    fovea.Depth_bot = getFoveaDepthBottom(i, mvFoveaParams);
                    fovea.Coef_symmetry = getFoveaSymmetry(i, mvFoveaParams);
                    fovea.Coef_normality = getFoveaNormality(i, mvFoveaParams);

                    globalFoveaLength += fovea.Length;
                    globalFoveaDepthTop += fovea.Depth_top;
                    globalFoveaDepthBot += fovea.Depth_bot;
                    globalFoveaSymmetry += fovea.Coef_symmetry;
                    globalFoveaNormality += fovea.Coef_normality;
            
                    survey.Foveas.Add(fovea);
                }

                folding = new Folding();
                folding.Num_snapshot = i;
                folding.Max_amplitude = getFoldingMaxAmp(i, mvFoldingParams);
                folding.Min_amplitude = getFoldingMinAmp(i, mvFoldingParams);
                folding.Mean_amplitude = getFoldingMeanAmp(i, mvFoldingParams);
                folding.N = getFoldingN(i, mvFoldingParams);
                survey.Foldings.Add(folding);

                globalMaxAmp += folding.Max_amplitude;
                globalMinAmp += folding.Min_amplitude;
                globalMeanAmp += folding.Mean_amplitude;
                globalN += folding.N;


                critical_points = new Critical_points();
                correlation = new Correlation();

                if (i < 19)
                {
                    critical_points.Num_first_snapshot = i;
                    critical_points.Num_second_snapshot = i + 1;
                    critical_points.Count = getLocalCriticalPointsCount(mwCriticalPointsParams,i);
                    survey.Critical_points.Add(critical_points);

                    correlation.Num_first_snapshot = i;
                    correlation.Num_second_snapshot = i + 1;
                    correlation.Сoefficient = getLocalCorrelationCoef(mwCorcoefParams,i);
                    survey.Correlations.Add(correlation);
                }
            }
            survey.Global_max_amplitude = globalMaxAmp / 19;
            survey.Global_min_amplitude = globalMinAmp / 19;
            survey.Global_mean_amplitude = globalMeanAmp / 19;
            survey.Global_n = (int)(globalN / 19);

            if (survey.Foveas.Count != 0)
            {
                survey.Global_fovea_length = globalFoveaLength / survey.Foveas.Count;
                survey.Global_fovea_depth_top = globalFoveaDepthTop / survey.Foveas.Count;
                survey.Global_fovea_depth_bot = globalFoveaDepthBot / survey.Foveas.Count;
                survey.Global_fovea_coef_symmetry = globalFoveaSymmetry / survey.Foveas.Count;
                survey.Global_fovea_coef_normality = globalFoveaNormality / survey.Foveas.Count;
            }

            survey.Global_sum_variability = globalAllCorner / 19;
            survey.Global_median_variability = globalMeanCorner / 19;

            return survey;
        }
    }
}
