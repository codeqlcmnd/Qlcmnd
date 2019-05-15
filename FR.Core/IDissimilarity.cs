namespace PatternRecognition.Core
{
    public interface IDissimilarity <T> 
    {
        
        double Compare(T source, T compareTo);
    }
}