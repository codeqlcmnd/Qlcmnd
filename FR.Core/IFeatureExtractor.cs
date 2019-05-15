using System.Drawing;

namespace PatternRecognition.FingerprintRecognition.Core
{
   
    public interface IFeatureExtractor
    {
    
        object ExtractFeatures(Bitmap image);
    }

   
    public interface IFeatureExtractor<FeatureType> : IFeatureExtractor
    {
       
        new FeatureType ExtractFeatures(Bitmap image);
    }

   
    public abstract class FeatureExtractor<FeatureType> : IFeatureExtractor<FeatureType>
    {
        #region IFeatureExtractor<FeatureType> Members

        /// <summary>
        ///     When implemented in a derived class, extract features from the specified image.
        /// </summary>
        /// <param name="image">The source image to extract features from.</param>
        /// <returns>The features extracted from the specified image.</returns>
        public abstract FeatureType ExtractFeatures(Bitmap image);

        #endregion

        #region IFeatureExtractor Members

        /// <summary>
        ///     Extract features from the specified image.
        /// </summary>
        /// <param name="image">The source image to extract features from.</param>
        /// <returns>The features extracted from the specified image.</returns>
        object IFeatureExtractor.ExtractFeatures(Bitmap image)
        {
            return ExtractFeatures(image);
        }

        #endregion
    }
}