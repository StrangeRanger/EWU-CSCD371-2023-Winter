namespace Logger;

public class ObjectInitializer {
    public string ClassName { get; set; }
}

public class LogFactory {
    public string Name { get; set; }

    LogFactory() { Name = "CHANGE_ME"; }

    public BaseLogger CreateLogger(string className) { return null; }
}

