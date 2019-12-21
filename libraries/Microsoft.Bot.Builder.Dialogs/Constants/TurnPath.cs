﻿namespace Microsoft.Bot.Builder.Dialogs
{
    public class TurnPath
    {
        /// <summary>
        /// The result from the last dialog that was called.
        /// </summary>
        public const string LastResult = "turn.lastresult";

        /// <summary>
        /// The current activity for the turn.
        /// </summary>
        public const string Activity = "turn.activity";

        /// <summary>
        /// The recognized result for the current turn.
        /// </summary>
        public const string Recognized = "turn.recognized";

         /// <summary>
        /// Path to the top intent.
        /// </summary>
        public const string TopIntent = "turn.recognized.intent";

        /// <summary>
        /// Path to the top score.
        /// </summary>
        public const string TopScore = "turn.recognized.score";

        /// <summary>
        /// Original text.
        /// </summary>
        public const string Text = "turn.recognized.text";

        /// <summary>
        /// Original utterance split into unrecognized strings.
        /// </summary>
        public const string UnrecognizedText = "turn.unrecognizedText";

        /// <summary>
        /// Entities that were recognized from text.
        /// </summary>
        public const string RecognizedEntities = "turn.recognizedEntities";

        /// <summary>
        /// If true an interruption has occured.
        /// </summary>
        public const string Interrupted = "turn.interrupted";

        /// <summary>
        /// The current dialog event (set during event processings).
        /// </summary>
        public const string DialogEvent = "turn.dialogEvent";

        /// <summary>
        /// Used to track that we don't end up in infinite loop of RepeatDialogs().
        /// </summary>
        public const string RepeatedIds = "turn.repeatedIds";

        /// <summary>
        /// This is a bool which if set means that the turncontext.activity has been consumed by some component in the system.
        /// </summary>
        public const string ActivityProcessed = "turn.activityProcessed";
    }
}
