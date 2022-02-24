namespace GenAlphaMaui.Services;

public interface IAudioService
{
    Task InitializeAsync(string audioURI);
    Task PlayAsync(double position = 0);
    Task PauseAsync();
    bool IsPlaying {  get; }
    double CurrentPosition {  get; }
}
