using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Models
{
    class MLDayPredict : DayModel
    {
        [ColumnName("PredictedLabel")]
        public float Prediction { get; set; }

        public float Probability { get; set; }

        public float[] Score { get; set; }
    }
}
