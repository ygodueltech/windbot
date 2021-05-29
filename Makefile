.PHONY: build run help

DECK="Dragun"

all: default

default: help

build: ## xbuild and chmod ./bin/Debug/WindBot.exe
	xbuild
	chmod +x ./bin/Debug/WindBot.exe

run: ## run it
	./bin/Debug/WindBot.exe Host=127.0.0.1 Port=7911 Debug=True Deck=$(DECK) Name=p$(DECK)
runlog: ## run logging stdout to duel.log
	./bin/Debug/WindBot.exe Host=127.0.0.1 Port=7911 Debug=True Deck=$(DECK) Name=p$(DECK) | tee duel.log

buildrun:build run ## build then run

help:
	@grep -E '^[a-zA-Z0-9_-]+:.*?## .*$$' $(MAKEFILE_LIST) | sort | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'
