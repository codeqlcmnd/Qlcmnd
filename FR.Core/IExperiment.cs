
using System.ComponentModel;
using PatternRecognition.FingerprintRecognition.Core;

namespace PatternRecognition.FingerprintRecognition.Core
{
   
    public interface IExperiment
    {
      
        void Execute();

        event ProgressChangedEventHandler StatusEvent;
    }

    public interface IMatchingExperiment : IExperiment
    {
      
        string ResourcePath { get; set; }

        IMatcher Matcher { set; get; }

        IResourceProvider ResourceProvider { set; get; }
    }
}