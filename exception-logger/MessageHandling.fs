namespace MessageHandling

module Messages=
    type ExceptionLog = {
        messsage: string;
        stackTrace: string
    }

    type Message = 
        | ExceptionLog of ExceptionLog

module Handling=
    open Messages

    let logToErrBit exLog=
        ()

    let Handle msg=
        match msg with
        | ExceptionLog el -> logToErrBit el