using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarFeatureDtos
{
    public class ResultCarFeatureByCarIdDto
    {
        public int carFeatureID { get; set; }
        public int carID { get; set; }
        public int featureID { get; set; }
        public object featureName { get; set; }
        public bool available { get; set; }
    }
}
