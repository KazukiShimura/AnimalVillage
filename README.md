# AnimalVillage

## 更新履歴
- 2021/05/14(発表時)

## 概要
スマホゲームでよくある放置ゲームです。

## ゲーム内容
- 時間経過でゴールドを獲得できます
- キャラクターにリンゴや薬を上げることでハートを獲得できます
- 獲得したゴールドによって新マップを追加できます
- 獲得したハートによってキャラクターを追加できます
- ゲーム進捗ミッションをこなすことでダイヤを獲得できます

## コードの説明

## 工夫した点、苦労した点
- 2DのUI上に3Dキャラクターを表示させる機能（キャラクター選択画面）
- キャラクターが自由にうろうろする動作の実装
- 新マップ生成時に動的にNavMeshでBakeする機能
- Bakeしたマップ上にキャラクターを生成する際のエラー対処（NavMeshAgentの実行タイミング）
- 画面下部の電光掲示板のような流れるテキストの演出
- マップ・キャラクター生成時のDOTweenによるダイナミックな演出

## 追加したい機能、課題、今後の取り組み
- セーブ機能の実装
- 各キャラクター特有イベントの実装（猫とじゃんけん、犬とおいかけっこ、鳥の卵集め・・・など）