﻿# 新空间技术方案

## 关注问题和背景

新空间关注的主要问题：

- 角色差异、个性化
- 业务聚合模式（模块和空间的数据交互与通讯方案）
- 粘性激励方案（计分、反馈等）
- UI美观度，设计规范性
- 数据汇聚和归档（成长袋）

## 角色差异、个性化

空间路由切换方案（目前已经实现以空间类型文件夹分类组织代码，可直接沿用）：

- SpaceControllerProvider.cs 负责修正命名空间（目前基于UserType，但可能需要基于角色）
- SpaceRouteFilter.cs 负责修正View（根据空间类型文件夹查找）

可按需对切换空间类型的代码逻辑稍作调整（确定用户的空间类型）

新空间（YDJY版）使用另一套菜单（不同的Controller命名），这样可以不修改原有云平台的空间代码。
例如： YDJYHomeController.Index


## 业务聚合模式

参考《组件聚合方案说明》

目前已知：
空间聚合首页（常用操作菜单， 我的工作安排）
...

## 粘性激励方案

todo 积分系统的设计与实现

## UI设计与规范

基于现有的Vue UI Fx的新规范

## 数据汇聚和归档

一个以“我”为中心的数据中心

- 我的成长袋
- ...