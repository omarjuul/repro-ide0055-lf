#pragma warning disable CS8321 // Local function is declared but never used

static int GetTheValueWithComment() =>
    // A comment
    42;

static int GetTheValueWithCommentAlternative()
    // A comment
    => 42;

static int GetTheValue() => 42;

static int GetTheValueNewlineFirst()
    => 42;

static int GetTheValueNewlineAfter() =>
    42;