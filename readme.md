## 工程介绍
- 这是一个可玩的网游 + 网游框架，将包含制作一款mmorpg的所有必要内容
- 为什么要开这个工程
    - 我喜欢做游戏，想看着游戏中有趣的一切从我手中诞生
    - 很多想实践的技术没有一个上下文，这个游戏是我的大玩具，是实验室，可以验证我的想法
    - 随着游戏内容增加，技术使用和研究会变得广播并且深入，这个工程将伴我成长
- 因为会在里面验证很多技术和想法，会加入无限世界的设定，各种奇怪的副本，比如多客户端参与的基于帧同步的副本

## 客户端和服务器共用的部分
- 客户端和游戏服务器都使用c#实现，一些库是服务器和客户端共用，如读Excel表、网络、网络协议、序列化、数学
- Excel转表、读表工具：tabtoy
- 序列化库protobuf
- 网络库：使用系统socket编程接口封装的代码，目前仅支持TCP，将来根据情况会换成我编写的可靠udp，也会支持kcp
- 网络协议：基于protobuf自己封装定义的格式
- 一键转表、转协议、自动生成网络协议解析代码，这套工具链我感觉还不错

## 服务器
- 使用python的Django实现游戏应用服务器，处理用户管理
- 数据库：目前是sqllit，如果换到上线环境我会换成mysql
- 游戏服务器使用c#，目前是处理客户端请求的部分使用多线程模型，将来会改成单线程异步网络模型
- 游戏应用服务器基于我以前在学校和实习的时候学习的java服务器开发知识，尽我所能的做，以后借鉴优秀的开源游戏服务器框架来优化重构
- 服务器这边的开发呢我追求能用不卡，暂时不会放太多精力

## 客户端
- 客户端这边是有阶段的，如下
    - 游戏基础系统和内容完成
    - 各类游戏副本添加
    - 游戏优化，包括性能、代码重构
    - 自动化构建，最终还是要打包上线的
- 游戏主体使用基于组件的架构，使用Unity + c# + lua进行开发，会有基于ecs+jobsystem的副本，这个副本有大量的怪，很多ai计算
- 渲染方面
    - 先用通用管线，有空了我会考虑用scriptable render pipeline，也可能开新的坑
    - shader肯定是要写的，尝试不同的渲染风格化，写一写有趣的特效
    - 先定一些督促自己：体积光(体积光写过demo，高效果机器带不动的)、体积雾、实时天气、真实水体
- 客户端这边会涉及的技术
    - 资源管理，包括ab工具、增量更新
    - 技能系统，这块mmo需要服务器配合，帧同步客户端这边也要计算
        - 架构+流程
        - 技能表现
        - 数值
    - AI架构和框架
        - 通用状态机框架
        - 行为树框架
    - 捏脸，捏脸的原理不负责，好看的脸模板需要优秀的美术
    - 换装

## end
- 待续...