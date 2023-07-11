using Tested;

var myQueueInteger = new MyQueue<int>();

myQueueInteger.Queue(1);
myQueueInteger.Queue(2);
myQueueInteger.Queue(3);
myQueueInteger.Queue(4);

myQueueInteger.Dequeue();
myQueueInteger.Peek();

//-------------------------------------------

var myQueueString = new MyQueue<string>();

myQueueString.Queue("Marco");
myQueueString.Queue("Luca");
myQueueString.Queue("Emanuele");
myQueueString.Queue("Alberto");

myQueueString.Dequeue();
myQueueString.Peek();







