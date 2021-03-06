namespace PlaywrightSharp
{
    /// <summary>
    /// Three-state boolean. See <seealso cref="SerializedAXNode.Checked"/>.
    /// </summary>
    public enum CheckedState
    {
        /// <summary>
        /// Checked.
        /// </summary>
        Checked = 0,

        /// <summary>
        /// Unchecked.
        /// </summary>
        Unchecked,

        /// <summary>
        /// Mixed.
        /// </summary>
        Mixed,
    }
}
