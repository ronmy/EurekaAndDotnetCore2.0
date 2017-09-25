# EurekaAndDotnetCore2.0

本是例子是 Euerka 与 dotnetcore webapi 相结合的例子，在mac上已经编译完成，都已经上传，并在centos 7上试验成功；

例子测试了.net webapi服务注册到euerka及负载均衡（8010实例随机访问8011与8012）；

机子IP：192.168.1.103；

# 看效果过程

1、先启动 

  cd 本例子/Eureka/serviceserver2/out/artifacts/serviceserver_2
  
  vim application.properties #参数配置文件

  java -jar serviceserver.jar

  打开 http://192.168.1.103:8761 可以看到 eureka监控界面； 
   
2、再依次启动
   
   #port : 8010
   
   cd   本例子/DotnetCore2.0/sscore/bin/Debug/netcoreapp2.0/publish
   
   vim appsettings.json #链接到Eureka的参数配置文件
   
   vim hosting.json #host的启动ip与端的参数配置文件

   dotnet sscore.dll
   
   #port: 8011
   
   cd   本例子/DotnetCore2.0/sscore2/bin/Debug/netcoreapp2.0/publish
    
   vim appsettings.json #链接到Eureka的参数配置文件
   
   vim hosting.json #host的启动ip与端的参数配置文件
   
   dotnet sscore2.dll
   
   #port 8012
   
   cd   本例子/DotnetCore2.0/sscore3/bin/Debug/netcoreapp2.0/publish
      
   vim appsettings.json #链接到Eureka的参数配置文件
   
   vim hosting.json #host的启动ip与端的参数配置文件
   
   dotnet sscore3.dll
 
3、效果

  访问 http://192.168.1.103:8010/api/values/cloud 时， http://192.168.1.103:8011/api/values
与 http://192.168.1.103:8012/api/values 的访问结果随机显示。  
   
   
   
