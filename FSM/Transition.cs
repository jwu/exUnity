// ======================================================================================
// File         : Transition.cs
// Author       : Wu Jie 
// Last Change  : 12/20/2011 | 12:02:07 PM | Tuesday,December
// Description  : 
// ======================================================================================

///////////////////////////////////////////////////////////////////////////////
// usings
///////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

///////////////////////////////////////////////////////////////////////////////
// defines
///////////////////////////////////////////////////////////////////////////////

namespace fsm {

    ///////////////////////////////////////////////////////////////////////////////
    // Transition
    ///////////////////////////////////////////////////////////////////////////////

    [System.Serializable]
    public class Transition {

        ///////////////////////////////////////////////////////////////////////////////
        // properties
        ///////////////////////////////////////////////////////////////////////////////

        public Machine machine {
            get {
                if ( source != null )
                    return source.machine;
                return null;
            }
        }

        public State source = null;
        public State target = null;
        public System.Func<bool> onCheck = delegate () { return false; }; 

        public System.Action onStart = null;
        public System.Func<bool> onTransition = delegate () { return true; }; 
        public System.Action onEnd = null;
    }
}

