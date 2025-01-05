using Microsoft.ML.Data;

namespace NoSoliciting.Interface;

public class PredictionBinary {
    [ColumnName("PredictedLabel")]
    public bool PredictedIsNormal { get; set; }
    
    public float Probability { get; set; }

    public float Score { get; set; }
}