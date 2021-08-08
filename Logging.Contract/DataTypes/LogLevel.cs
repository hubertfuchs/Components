namespace Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes
{
    public enum LogLevel : byte
    {
        /// <summary>
        /// Protokolliert Informationen, die in der Regel nur für das Debuggen nützlich sind. 
        /// Diese Meldungen können sensible Anwendungsdaten enthalten und sollten daher nicht in einer Produktionsumgebung aktiviert werden. 
        /// Standardmäßig deaktiviert.
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Protokolliert Informationen, die bei der Entwicklung und beim Debuggen hilfreich sein können. 
        /// Beispiel: Entering method Configure with flag set to true. 
        /// Aktivieren Sie Protokolle mit dem Protokolliergrad Debug aufgrund des hohen Protokollaufkommens nur zur Problembehandlung in der Produktion.
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Zur Nachverfolgung des allgemeinen Ablaufs der App. 
        /// Diese Protokolle haben typischerweise einen langfristigen Nutzen. 
        /// Ein Beispiel: Request received for path /api/todo
        /// </summary>
        Information = 2,

        /// <summary>
        /// Für ungewöhnliche oder unerwartete Ereignisse im App-Verlauf. 
        /// Dazu können Fehler oder andere Bedingungen gehören, die zwar nicht zum Beenden der App führen, aber eventuell untersucht werden müssen. 
        /// Behandelte Ausnahmen sind eine typische Verwendung für den Protokolliergrad Warning. 
        /// Ein Beispiel: FileNotFoundException for file quotes.txt.
        /// </summary>
        Warning = 3,

        /// <summary>
        /// Für Fehler und Ausnahmen, die nicht behandelt werden können. 
        /// Diese Meldungen weisen auf einen Fehler in der aktuellen Aktivität oder im aktuellen Vorgang (z.B. in der aktuellen HTTP-Anforderung) 
        /// und nicht auf einen anwendungsweiten Fehler hin. 
        /// Beispielprotokollmeldung: Cannot insert record due to duplicate key violation.
        /// </summary>
        Error = 4,

        /// <summary>
        /// Für Fehler, die sofortige Aufmerksamkeit erfordern. 
        /// Beispiel: Szenarios mit Datenverlust, Speichermangel.
        /// </summary>
        Critical = 5,

        /// <summary>
        /// Wird nicht zum Schreiben von Protokollmeldungen verwendet. 
        /// Gibt an, dass eine Logging-Kategorie keine Meldungen schreiben soll.
        /// </summary>
        None = 6
    }
}
