ver=1.0.0
docker build -t "scholtz2/algorand-staking-bot:$ver-stable" -f AlgorandStakingBot/Dockerfile  ./
docker push "scholtz2/algorand-staking-bot:$ver-stable"
echo "Image: scholtz2/algorand-staking-bot:$ver-stable"
