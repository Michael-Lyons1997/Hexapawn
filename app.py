from flask import Flask, request, render_template

app = Flask(__name__)

@app.get("/")
def index(request):
    return render_template("mainMenu.html",title="Hexapawn")

@app.get("/singleplayer")
def singlePlayer(request):
    return render_template("singleplayer.html",title="Hexapawn")

@app.get("/multiplayer")
def multiplayer(request):
    return render_template("singleplayer.html",title="Hexapawn")


if __name__ == '__main__':
    app.run(debug=True)
