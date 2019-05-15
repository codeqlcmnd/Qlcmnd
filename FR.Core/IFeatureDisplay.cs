
using System;
using System.Drawing;

namespace PatternRecognition.FingerprintRecognition.Core
{
    public interface IFeatureDisplay
    {
       
        void Show(object features, Graphics g);
    }

   
    public interface IFeatureDisplay<FeatureType> : IFeatureDisplay
    {
       
        void Show(FeatureType features, Graphics g);
    }

   
    public abstract class FeatureDisplay<FeatureType> : IFeatureDisplay<FeatureType>
    {
        #region IFeatureDisplay<FeatureType> Members

        /// <summary>
        ///     When implemented in a derived class, paints the specified features using the specified <see cref="Graphics"/>.
        /// </summary>
        /// <param name="features">The features to be painted.</param>
        /// <param name="g">The <see cref="Graphics"/> object used to paint the features.</param>
        public abstract void Show(FeatureType features, Graphics g);

        #endregion

        #region IFeatureDisplay Members

        /// <summary>
        ///     Paints the specified features using the specified <see cref="Graphics"/>.
        /// </summary>
        /// <param name="features">The features to be painted.</param>
        /// <param name="g">The <see cref="Graphics"/> object used to paint the features.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the type of the specified features is not correct.
        /// </exception>
        public void Show(object features, Graphics g)
        {
            if (features.GetType() != typeof(FeatureType))
            {
                string msg = "Unable to display features: Invalid features type!";
                throw new ArgumentOutOfRangeException("features", features, msg);
            }
            Show((FeatureType)features, g);
        }

        #endregion
    }
}