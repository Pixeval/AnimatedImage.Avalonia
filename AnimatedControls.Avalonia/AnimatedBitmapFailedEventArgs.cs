using System;

namespace AnimatedControls.Avalonia;

public class AnimatedBitmapFailedEventArgs(Exception exception) : EventArgs
{
    public Exception Exception { get; set; } = exception;
}
