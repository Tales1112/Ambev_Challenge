namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines way to access current user data.
    /// </summary>
    public interface ICurrentUserAccessor
    {
        /// <summary>
        /// Retrieves current user of the system.
        /// </summary>
        /// <returns>User of the system.</returns>
        IUser GetCurrentUser();
    }
}
