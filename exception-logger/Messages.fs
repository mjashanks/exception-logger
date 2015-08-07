namespace ExLog.Messages

type ExceptionLog = {
    messsage: string;
    stackTrace: string
}

type Message = 
    | ExceptionLog of ExceptionLog
    | Text of string
