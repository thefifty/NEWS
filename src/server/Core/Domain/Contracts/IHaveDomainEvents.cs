namespace Core;

/*
public interface IHaveDomainEvents
{
    /// <summary>
    /// Does the aggregate have change that have not been committed to storage
    /// </summary>
    /// <returns></returns>
    public bool HasUncommittedDomainEvents();

    /// <summary>
    /// Gets a list of uncommitted events for this aggregate.
    /// </summary>
    /// <returns></returns>
    IReadOnlyList<IDomainEvent> GetUncommittedDomainEvents();

    /// <summary>
    /// Gets a list of uncommitted events for this aggregate, mark all events as committed.
    /// </summary>
    /// <returns></returns>
    IReadOnlyList<IDomainEvent> DequeueUncommittedDomainEvents();

    /// <summary>
    /// Mark all changes (events) as committed, clears uncommitted changes and updates the current version of the aggregate.
    /// </summary>
    void MarkUncommittedDomainEventAsCommitted();

    /// <summary>
    /// Check specific rule for aggregate and throw an exception if rule is not satisfied.
    /// </summary>
    /// <param name="rule"></param>
    void CheckRule(IBusinessRule rule);
}*/