namespace ZetaAsync;

/// <summary>
/// Interface for items that have an order position.
/// </summary>
[PublicAPI]
public interface IOrderPosition
{
    int OrderPosition { get; set; }

    /// <summary>
    /// Persist the new order position to database.
    /// </summary>
    void StoreOrderPosition(
        object threadPoolManager,
        object? postExecuteCallback,
        AsynchronousMode asynchronousMode,
        object? userValue);
}