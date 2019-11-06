### Console重定向及GUI程序调用

- Console重定向本质是流重定向
- 使用win32 api初始化Console，保留对Console.Out的引用
- 重定向到自定义System.IO.TextWriter

<br />
<br />

---
**引用**

    * https://www.cnblogs.com/wangchuang/p/5809678.html
    * https://blog.csdn.net/wangxvfeng101/article/details/7477210
    * https://www.cnblogs.com/94cool/p/4409122.html