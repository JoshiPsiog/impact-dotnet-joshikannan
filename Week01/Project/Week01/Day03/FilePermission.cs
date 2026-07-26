namespace Week01.Day03;

/// <summary>
/// Flags enum representing file permissions.
/// Multiple permissions can be combined using the bitwise OR (|) operator.
/// </summary>
[Flags]
public enum FilePermission
{
    Read = 1,
    Write = 2,
    Execute = 4
}