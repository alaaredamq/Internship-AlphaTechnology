﻿namespace Abstract_Factory.Chain_of_responsibilities; 

public abstract class Handler {
    protected Handler successor;

    public void SetSuccessor(Handler successor) {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}