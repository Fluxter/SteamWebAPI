namespace PortableSteam
{
    /// <summary>
    /// The file format to return output in.
    /// </summary>
    public enum RequestFormat
    {
        /// <summary>
        /// The JavaScript Object Notation format.
        /// </summary>
        JSON,
        /// <summary>
        /// Valve Data Format.
        /// </summary>
        /// <remarks>
        /// http://wiki.teamfortress.com/wiki/WebAPI/VDF
        /// </remarks>
        VDF,
        /// <summary>
        /// Standard XML.
        /// </summary>
        XML
    }
}
