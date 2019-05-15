
namespace PatternRecognition.Core
{
  
    public interface IBooleanSimilarity<T>
    {
       
        bool Compare(T source, T compareTo);
    }
}