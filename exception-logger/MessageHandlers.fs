namespace ExLog
open ExLog.Messages

module Handlers=

    let ErrBit (msg:ExceptionLog)=
        printfn "Errbit: message: %s" msg.messsage

    let Text msg=
        printfn "TextMessage: message: %s" msg